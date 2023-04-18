namespace lab2
{
    partial class Bai3
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
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.ReadFile = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.WriteFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(48, 129);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(384, 337);
            this.Input.TabIndex = 0;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(497, 129);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(384, 337);
            this.Output.TabIndex = 1;
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(48, 30);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(232, 60);
            this.ReadFile.TabIndex = 2;
            this.ReadFile.Text = "Đọc";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.ReadFile_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(345, 30);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(232, 60);
            this.Calculate.TabIndex = 3;
            this.Calculate.Text = "Tính";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // WriteFile
            // 
            this.WriteFile.Location = new System.Drawing.Point(649, 30);
            this.WriteFile.Name = "WriteFile";
            this.WriteFile.Size = new System.Drawing.Size(232, 60);
            this.WriteFile.TabIndex = 4;
            this.WriteFile.Text = "Ghi";
            this.WriteFile.UseVisualStyleBackColor = true;
            this.WriteFile.Click += new System.EventHandler(this.WriteFile_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 520);
            this.Controls.Add(this.WriteFile);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.ReadFile);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button WriteFile;
    }
}