using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai1 bai1 = new Bai1();
            bai1.Owner = this;
            bai1.Show();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai2 bai2 = new Bai2();
            bai2.Owner = this;
            bai2.Show();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai3 bai3 = new Bai3();
            bai3.Owner = this;
            bai3.Show();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai4 bai4 = new Bai4();
            bai4.Owner = this;
            bai4.Show();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai5 bai5 = new Bai5();
            bai5.Owner = this;
            bai5.Show();
        }
    }
}
