namespace lab2
{
    partial class Bai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadFile = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.NameFile = new System.Windows.Forms.TextBox();
            this.UrlFile = new System.Windows.Forms.TextBox();
            this.LineNumber = new System.Windows.Forms.TextBox();
            this.WordNumber = new System.Windows.Forms.TextBox();
            this.CharNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(54, 52);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(255, 65);
            this.ReadFile.TabIndex = 0;
            this.ReadFile.Text = "Đọc File";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.ReadFile_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(356, 33);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(416, 394);
            this.textBox.TabIndex = 1;
            // 
            // NameFile
            // 
            this.NameFile.Location = new System.Drawing.Point(137, 161);
            this.NameFile.Name = "NameFile";
            this.NameFile.ReadOnly = true;
            this.NameFile.Size = new System.Drawing.Size(190, 29);
            this.NameFile.TabIndex = 2;
            // 
            // UrlFile
            // 
            this.UrlFile.Location = new System.Drawing.Point(137, 212);
            this.UrlFile.Name = "UrlFile";
            this.UrlFile.ReadOnly = true;
            this.UrlFile.Size = new System.Drawing.Size(190, 29);
            this.UrlFile.TabIndex = 3;
            // 
            // LineNumber
            // 
            this.LineNumber.Location = new System.Drawing.Point(137, 264);
            this.LineNumber.Name = "LineNumber";
            this.LineNumber.ReadOnly = true;
            this.LineNumber.Size = new System.Drawing.Size(190, 29);
            this.LineNumber.TabIndex = 4;
            // 
            // WordNumber
            // 
            this.WordNumber.Location = new System.Drawing.Point(137, 319);
            this.WordNumber.Name = "WordNumber";
            this.WordNumber.ReadOnly = true;
            this.WordNumber.Size = new System.Drawing.Size(190, 29);
            this.WordNumber.TabIndex = 5;
            // 
            // CharNumber
            // 
            this.CharNumber.Location = new System.Drawing.Point(137, 372);
            this.CharNumber.Name = "CharNumber";
            this.CharNumber.ReadOnly = true;
            this.CharNumber.Size = new System.Drawing.Size(190, 29);
            this.CharNumber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số dòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số ký tự";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CharNumber);
            this.Controls.Add(this.WordNumber);
            this.Controls.Add(this.LineNumber);
            this.Controls.Add(this.UrlFile);
            this.Controls.Add(this.NameFile);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.ReadFile);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox NameFile;
        private System.Windows.Forms.TextBox UrlFile;
        private System.Windows.Forms.TextBox LineNumber;
        private System.Windows.Forms.TextBox WordNumber;
        private System.Windows.Forms.TextBox CharNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}