using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsScraper
{
    public partial class NewsItem : Bunifu.UI.WinForms.BunifuUserControl
    {
        String url;
        public NewsItem()
        {
            InitializeComponent();
        }

        public Image ItemImage {
            get
            {
                return bunifuPictureBox1.Image;
            }
            set
            {
                bunifuPictureBox1.Image = value;
            }
        }

        public String ItemLabel
        {
            get
            {
                return TimeLabel.Text;
            }
            set
            {
                TimeLabel.Text = value;
            }
        }
        public String ItemTitle
        {
            get
            {
                return TitleLabel.Text;
            }
            set
            {
                TitleLabel.Text = value;
            }
        }

        public String ItemDescription
        {
            get
            {
                return DescriptionLabel.Text;
            }
            set { DescriptionLabel.Text = value; }
        }

        public String ItemUrl
        {
            get
            {
                return url;
            }
            set { url = value; }
        }

        private void btnReadMore_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ItemUrl))
            {
                try
                {
                    System.Diagnostics.Process.Start(ItemUrl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't open browser: " + ex.Message);
                }
            }
        }
    }
}
