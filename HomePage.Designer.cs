
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserInfoPic = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchBox = new LibrarySystem.SearchBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ManagePic);
            this.flowLayoutPanel1.Controls.Add(this.BorrowPic);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.UserInfoPic);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(258, 1024);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // ManagePic
            // 
            this.ManagePic.Image = global::LibrarySystem.Properties.Resources.Manage1;
            this.ManagePic.Location = new System.Drawing.Point(3, 3);
            this.ManagePic.Name = "ManagePic";
            this.ManagePic.Size = new System.Drawing.Size(250, 250);
            this.ManagePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ManagePic.TabIndex = 8;
            this.ManagePic.TabStop = false;
            this.ManagePic.Click += new System.EventHandler(this.ManagePic_Click);
            // 
            // BorrowPic
            // 
            this.BorrowPic.Image = global::LibrarySystem.Properties.Resources.Borrow1;
            this.BorrowPic.Location = new System.Drawing.Point(3, 259);
            this.BorrowPic.Name = "BorrowPic";
            this.BorrowPic.Size = new System.Drawing.Size(250, 250);
            this.BorrowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BorrowPic.TabIndex = 7;
            this.BorrowPic.TabStop = false;
            this.BorrowPic.Click += new System.EventHandler(this.BorrowPic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibrarySystem.Properties.Resources.Borrow2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 515);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // UserInfoPic
            // 
            this.UserInfoPic.Image = global::LibrarySystem.Properties.Resources.User1;
            this.UserInfoPic.Location = new System.Drawing.Point(3, 771);
            this.UserInfoPic.Name = "UserInfoPic";
            this.UserInfoPic.Size = new System.Drawing.Size(250, 250);
            this.UserInfoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserInfoPic.TabIndex = 9;
            this.UserInfoPic.TabStop = false;
            this.UserInfoPic.Click += new System.EventHandler(this.UserInfoPic_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(416, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1307, 786);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(669, 807);
            this.searchBox.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(798, 122);
            this.searchBox.TabIndex = 4;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1856, 1024);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.searchBox);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.HomPage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManagePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SearchBox searchBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BorrowPic;
        private System.Windows.Forms.PictureBox ManagePic;
        private System.Windows.Forms.PictureBox UserInfoPic;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}