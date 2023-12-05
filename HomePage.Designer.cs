﻿
namespace LibrarySystem
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ManagePic = new System.Windows.Forms.PictureBox();
            this.BorrowPic = new System.Windows.Forms.PictureBox();
            this.UserInfoPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WelcomePic = new System.Windows.Forms.PictureBox();
            this.searchBox = new LibrarySystem.SearchBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WelcomePic)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.ManagePic);
            this.flowLayoutPanel1.Controls.Add(this.BorrowPic);
            this.flowLayoutPanel1.Controls.Add(this.UserInfoPic);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(111, 469);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // ManagePic
            // 
            this.ManagePic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ManagePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManagePic.Image = global::LibrarySystem.Properties.Resources.Manage1;
            this.ManagePic.Location = new System.Drawing.Point(1, 1);
            this.ManagePic.Margin = new System.Windows.Forms.Padding(1);
            this.ManagePic.Name = "ManagePic";
            this.ManagePic.Size = new System.Drawing.Size(107, 111);
            this.ManagePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ManagePic.TabIndex = 8;
            this.ManagePic.TabStop = false;
            this.ManagePic.Click += new System.EventHandler(this.ManagePic_Click);
            // 
            // BorrowPic
            // 
            this.BorrowPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BorrowPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrowPic.Image = global::LibrarySystem.Properties.Resources.Borrow1;
            this.BorrowPic.Location = new System.Drawing.Point(1, 114);
            this.BorrowPic.Margin = new System.Windows.Forms.Padding(1);
            this.BorrowPic.Name = "BorrowPic";
            this.BorrowPic.Size = new System.Drawing.Size(107, 111);
            this.BorrowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BorrowPic.TabIndex = 7;
            this.BorrowPic.TabStop = false;
            this.BorrowPic.Click += new System.EventHandler(this.BorrowPic_Click);
            // 
            // UserInfoPic
            // 
            this.UserInfoPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserInfoPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserInfoPic.Image = global::LibrarySystem.Properties.Resources.User1;
            this.UserInfoPic.Location = new System.Drawing.Point(1, 227);
            this.UserInfoPic.Margin = new System.Windows.Forms.Padding(1);
            this.UserInfoPic.Name = "UserInfoPic";
            this.UserInfoPic.Size = new System.Drawing.Size(107, 111);
            this.UserInfoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserInfoPic.TabIndex = 9;
            this.UserInfoPic.TabStop = false;
            this.UserInfoPic.Click += new System.EventHandler(this.UserInfoPic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::LibrarySystem.Properties.Resources.Borrow2;
            this.pictureBox1.Location = new System.Drawing.Point(1, 340);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomePic
            // 
            this.WelcomePic.BackColor = System.Drawing.Color.Transparent;
            this.WelcomePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WelcomePic.Image = ((System.Drawing.Image)(resources.GetObject("WelcomePic.Image")));
            this.WelcomePic.Location = new System.Drawing.Point(178, 5);
            this.WelcomePic.Margin = new System.Windows.Forms.Padding(1);
            this.WelcomePic.Name = "WelcomePic";
            this.WelcomePic.Size = new System.Drawing.Size(560, 349);
            this.WelcomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WelcomePic.TabIndex = 9;
            this.WelcomePic.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.Transparent;
            this.searchBox.Location = new System.Drawing.Point(288, 359);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(342, 54);
            this.searchBox.TabIndex = 4;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BackgroundImage = global::LibrarySystem.Properties.Resources.background3;
            this.ClientSize = new System.Drawing.Size(827, 469);
            this.Controls.Add(this.WelcomePic);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.searchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManagePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WelcomePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SearchBox searchBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BorrowPic;
        private System.Windows.Forms.PictureBox ManagePic;
        private System.Windows.Forms.PictureBox UserInfoPic;
        private System.Windows.Forms.PictureBox WelcomePic;
    }
}