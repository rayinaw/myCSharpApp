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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Bai1_FormClosed);
        }
        private void Bai1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
        private void Read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = "";
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        textBox.Text += line + Environment.NewLine;
                    }
                }

            }
        }

        private void Write_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate))
                {
                    byte[] ct = Encoding.UTF8.GetBytes(textBox.Text.Trim());
                    fs.Write(ct, 0, ct.Length);
                }
            }
        }
    }
}
