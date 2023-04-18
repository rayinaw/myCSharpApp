namespace NewsScraper
{
    partial class NewsItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewsItem));
            this.TitleLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.TimeLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.DescriptionLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnReadMore = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AllowParentOverrides = false;
            this.TitleLabel.AutoEllipsis = false;
            this.TitleLabel.AutoSize = false;
            this.TitleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TitleLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(42, 242);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleLabel.Size = new System.Drawing.Size(299, 61);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "title";
            this.TitleLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TitleLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AllowParentOverrides = false;
            this.TimeLabel.AutoEllipsis = false;
            this.TimeLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TimeLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TimeLabel.Location = new System.Drawing.Point(30, 401);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimeLabel.Size = new System.Drawing.Size(38, 25);
            this.TimeLabel.TabIndex = 5;
            this.TimeLabel.Text = "time";
            this.TimeLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TimeLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AllowParentOverrides = false;
            this.DescriptionLabel.AutoEllipsis = false;
            this.DescriptionLabel.AutoSize = false;
            this.DescriptionLabel.CursorType = null;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(42, 309);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DescriptionLabel.Size = new System.Drawing.Size(299, 83);
            this.DescriptionLabel.TabIndex = 6;
            this.DescriptionLabel.Text = "decription";
            this.DescriptionLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.DescriptionLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnReadMore
            // 
            this.btnReadMore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReadMore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReadMore.FlatAppearance.BorderSize = 0;
            this.btnReadMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadMore.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.btnReadMore.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnReadMore.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.btnReadMore.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnReadMore.IconSize = 15;
            this.btnReadMore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReadMore.Location = new System.Drawing.Point(212, 392);
            this.btnReadMore.Margin = new System.Windows.Forms.Padding(0);
            this.btnReadMore.Name = "btnReadMore";
            this.btnReadMore.Size = new System.Drawing.Size(151, 46);
            this.btnReadMore.TabIndex = 7;
            this.btnReadMore.Text = "Read more";
            this.btnReadMore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadMore.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReadMore.UseVisualStyleBackColor = false;
            this.btnReadMore.Click += new System.EventHandler(this.btnReadMore_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 217);
            this.panel1.TabIndex = 8;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPictureBox1.AutoSizeHeight = false;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = false;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(13, 10);
            this.bunifuPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(358, 207);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // NewsItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.BorderRadius = 30;
            this.BorderThickness = 3;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReadMore);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TitleLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NewsItem";
            this.Size = new System.Drawing.Size(383, 458);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel TitleLabel;
        private Bunifu.UI.WinForms.BunifuLabel TimeLabel;
        private Bunifu.UI.WinForms.BunifuLabel DescriptionLabel;
        private FontAwesome.Sharp.IconButton btnReadMore;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}
