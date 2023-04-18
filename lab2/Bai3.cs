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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab2
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Bai3_FormClosed);
        }
        private void Bai3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void ReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Input.Text = "";
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Input.Text += line + Environment.NewLine;
                    }
                }

            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            string[] calculations = Input.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            foreach (string calculation in calculations)
            {
                try
                {
                    result += calculation + " = " + CalculateExpression(calculation).ToString() + Environment.NewLine;
                }
                catch (Exception ex)
                {
                    result += "Error: " + ex.Message + Environment.NewLine;
                }
            }
            Output.Text = result;
        }

        private double CalculateExpression(string expression)
        {
            string[] operands = expression.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
            double operand1 = double.Parse(operands[0]);
            double operand2 = double.Parse(operands[1]);
            char op = expression[operands[0].Length];
            switch (op)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':
                    return operand1 / operand2;
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }

        private void WriteFile_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate))
                {
                    byte[] ct = Encoding.UTF8.GetBytes(Output.Text.Trim());
                    fs.Write(ct, 0, ct.Length);
                }
            }
        }
    }
}
