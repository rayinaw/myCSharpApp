using NewsScraper.Properties;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Markup;

namespace NewsScraper
{
    public partial class Main : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 0;
        private Color borderColor = Color.FromArgb(49, 35, 171);
        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void Main_Paint_1(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnMaximinize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                // Lưu lại kích thước cửa sổ trước khi phóng to
                this.Tag = this.Size;
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                // Nếu đang ở trạng thái phóng to thì khôi phục lại kích thước cửa sổ trước đó
                if (this.Tag != null && this.Tag is Size)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.Size = (Size)this.Tag;
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private Image getImage(String url)
        {
            WebClient webClient = new WebClient();
            byte[] imageBytes = webClient.DownloadData(url);
            MemoryStream ms = new MemoryStream(imageBytes);
            Image image = Image.FromStream(ms);
            return image;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var client = new RestClient("https://api.marketaux.com/v1/news/all");
            client.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.Revalidate);
            var request = new RestRequest("", Method.GET);
            request.AddQueryParameter("api_token", "ToMzaNihstkDrSuQyUTBrL06Z28wQmRmGZi3dpr8");
            request.AddQueryParameter("language", "en");
            request.AddQueryParameter("industries", HttpUtility.UrlEncode(comboBox.SelectedItem.ToString()));
            request.AddQueryParameter("limit", "3");

            RestResponse response = (RestResponse)client.Execute(request);
            JObject jsonResponse = JObject.Parse(response.Content);
            JArray data = (JArray)jsonResponse["data"];
            var list = new NewsItem[3];
            int i = 0;
            foreach (JObject item in data)
            {
                string title = (string)item["title"];
                string description = (string)item["description"];
                string publishTime = (string)item["published_at"];
                String imageUrl = (string)item["image_url"];
                String pageUrl = (string)item["url"];
                list[i] = new NewsItem();
                list[i].ItemTitle = title;
                list[i].ItemDescription = description;

                DateTime dateTime = DateTime.Parse(publishTime);
                string shortTime = dateTime.ToString("dd/MM/yyyy HH:mm");
                list[i].ItemLabel = shortTime;
                list[i].ItemUrl = pageUrl;
                list[i].ItemImage = getImage(imageUrl);
                i++;
            }
            flowLayoutPanel1.Controls.AddRange(list);
        }
    }
}
