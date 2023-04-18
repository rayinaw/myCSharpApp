using System;
using System.IO;
using System.Windows.Forms;


namespace lab2
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Bai2_FormClosed);

        }
        private void Bai2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
  
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                webBrowser.Url = new Uri(fbd.SelectedPath);
                txtPath.Text = fbd.SelectedPath;
                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPath.Text))
            {
                string currentPath = txtPath.Text;
                DirectoryInfo directory = Directory.GetParent(currentPath);
                if (directory != null)
                {
                    txtPath.Text = directory.FullName;
                    webBrowser.Url = new Uri(directory.FullName);

                }
            }
        }
    }
}
