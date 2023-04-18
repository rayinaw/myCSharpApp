using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Bai2_FormClosed);

        }
        private void Bai2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
        private void ReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = "";
                int lineCount = 0;
                int wordCount = 0;
                int charCount = 0;
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        textBox.Text += line + Environment.NewLine;
                        string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        wordCount += words.Length;
                        charCount += line.Length;
                        lineCount += 1;
                    }
                }
                NameFile.Text = Path.GetFileName(ofd.FileName);
                UrlFile.Text = ofd.FileName;
                LineNumber.Text = lineCount.ToString();
                WordNumber.Text = wordCount.ToString();
                CharNumber.Text = charCount.ToString();
            }
        }
    }
}
