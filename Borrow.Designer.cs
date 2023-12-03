
namespace LibrarySystem
{
    partial class Borrow
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
            this.splitContainerOfHomePage = new System.Windows.Forms.SplitContainer();
            this.BookList = new System.Windows.Forms.ListBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.BorrowButton = new System.Windows.Forms.Button();
            this.BookInfoLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BookNameText = new System.Windows.Forms.TextBox();
            this.ExactSearch = new System.Windows.Forms.Label();
            this.DetailInfoText = new System.Windows.Forms.TextBox();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.BookCover = new System.Windows.Forms.PictureBox();
            this.BookDetailInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOfHomePage)).BeginInit();
            this.splitContainerOfHomePage.Panel1.SuspendLayout();
            this.splitContainerOfHomePage.Panel2.SuspendLayout();
            this.splitContainerOfHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerOfHomePage
            // 
            this.splitContainerOfHomePage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerOfHomePage.Location = new System.Drawing.Point(0, 0);
            this.splitContainerOfHomePage.Name = "splitContainerOfHomePage";
            // 
            // splitContainerOfHomePage.Panel1
            // 
            this.splitContainerOfHomePage.Panel1.BackColor = System.Drawing.SystemColors.Info;
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.BookList);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.ReturnButton);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.Status);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.BorrowButton);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.BookInfoLabel);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.SearchButton);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.BookNameText);
            this.splitContainerOfHomePage.Panel1.Controls.Add(this.ExactSearch);
            this.splitContainerOfHomePage.Panel1.Tag = "";
            // 
            // splitContainerOfHomePage.Panel2
            // 
            this.splitContainerOfHomePage.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainerOfHomePage.Panel2.Controls.Add(this.DetailInfoText);
            this.splitContainerOfHomePage.Panel2.Controls.Add(this.PictureLabel);
            this.splitContainerOfHomePage.Panel2.Controls.Add(this.BookCover);
            this.splitContainerOfHomePage.Panel2.Controls.Add(this.BookDetailInfo);
            this.splitContainerOfHomePage.Size = new System.Drawing.Size(1785, 778);
            this.splitContainerOfHomePage.SplitterDistance = 594;
            this.splitContainerOfHomePage.TabIndex = 0;
            // 
            // BookList
            // 
            this.BookList.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.BookList.FormattingEnabled = true;
            this.BookList.ItemHeight = 33;
            this.BookList.Location = new System.Drawing.Point(34, 210);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(518, 235);
            this.BookList.TabIndex = 8;
            this.BookList.SelectedIndexChanged += new System.EventHandler(this.BookList_SelectedIndexChanged);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold);
            this.ReturnButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ReturnButton.Location = new System.Drawing.Point(298, 487);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(254, 42);
            this.ReturnButton.TabIndex = 7;
            this.ReturnButton.Text = "RETURN";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Status.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.Red;
            this.Status.Location = new System.Drawing.Point(34, 580);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 38);
            this.Status.TabIndex = 6;
            // 
            // BorrowButton
            // 
            this.BorrowButton.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold);
            this.BorrowButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BorrowButton.Location = new System.Drawing.Point(34, 487);
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Size = new System.Drawing.Size(254, 42);
            this.BorrowButton.TabIndex = 4;
            this.BorrowButton.Text = "BORROW";
            this.BorrowButton.UseVisualStyleBackColor = true;
            this.BorrowButton.Click += new System.EventHandler(this.BorrowButton_Click);
            // 
            // BookInfoLabel
            // 
            this.BookInfoLabel.AutoSize = true;
            this.BookInfoLabel.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.BookInfoLabel.Location = new System.Drawing.Point(28, 161);
            this.BookInfoLabel.Name = "BookInfoLabel";
            this.BookInfoLabel.Size = new System.Drawing.Size(274, 32);
            this.BookInfoLabel.TabIndex = 3;
            this.BookInfoLabel.Text = "Book Information";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold);
            this.SearchButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SearchButton.Location = new System.Drawing.Point(394, 93);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(158, 40);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BookNameText
            // 
            this.BookNameText.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.BookNameText.Location = new System.Drawing.Point(34, 93);
            this.BookNameText.Name = "BookNameText";
            this.BookNameText.Size = new System.Drawing.Size(344, 40);
            this.BookNameText.TabIndex = 1;
            this.BookNameText.TextChanged += new System.EventHandler(this.BookNameText_TextChanged);
            // 
            // ExactSearch
            // 
            this.ExactSearch.AutoSize = true;
            this.ExactSearch.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExactSearch.Location = new System.Drawing.Point(28, 46);
            this.ExactSearch.Name = "ExactSearch";
            this.ExactSearch.Size = new System.Drawing.Size(193, 32);
            this.ExactSearch.TabIndex = 0;
            this.ExactSearch.Text = "ExactSearch";
            // 
            // DetailInfoText
            // 
            this.DetailInfoText.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.DetailInfoText.Location = new System.Drawing.Point(29, 93);
            this.DetailInfoText.Multiline = true;
            this.DetailInfoText.Name = "DetailInfoText";
            this.DetailInfoText.Size = new System.Drawing.Size(366, 615);
            this.DetailInfoText.TabIndex = 4;
            // 
            // PictureLabel
            // 
            this.PictureLabel.AutoSize = true;
            this.PictureLabel.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.PictureLabel.Location = new System.Drawing.Point(420, 43);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(182, 32);
            this.PictureLabel.TabIndex = 3;
            this.PictureLabel.Text = "Book Cover";
            // 
            // BookCover
            // 
            this.BookCover.Image = global::LibrarySystem.Properties.Resources.Coverage;
            this.BookCover.Location = new System.Drawing.Point(426, 93);
            this.BookCover.Name = "BookCover";
            this.BookCover.Size = new System.Drawing.Size(609, 615);
            this.BookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BookCover.TabIndex = 2;
            this.BookCover.TabStop = false;
            // 
            // BookDetailInfo
            // 
            this.BookDetailInfo.AutoSize = true;
            this.BookDetailInfo.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.BookDetailInfo.Location = new System.Drawing.Point(25, 43);
            this.BookDetailInfo.Name = "BookDetailInfo";
            this.BookDetailInfo.Size = new System.Drawing.Size(318, 32);
            this.BookDetailInfo.TabIndex = 0;
            this.BookDetailInfo.Text = "Detailed Information";
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 778);
            this.Controls.Add(this.splitContainerOfHomePage);
            this.Name = "Borrow";
            this.Text = "Borrow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Borrow_FormClosing);
            this.splitContainerOfHomePage.Panel1.ResumeLayout(false);
            this.splitContainerOfHomePage.Panel1.PerformLayout();
            this.splitContainerOfHomePage.Panel2.ResumeLayout(false);
            this.splitContainerOfHomePage.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOfHomePage)).EndInit();
            this.splitContainerOfHomePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerOfHomePage;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox BookNameText;
        private System.Windows.Forms.Label ExactSearch;
        private System.Windows.Forms.Label BookInfoLabel;
        private System.Windows.Forms.Button BorrowButton;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label BookDetailInfo;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.PictureBox BookCover;
        private System.Windows.Forms.Label PictureLabel;
        private System.Windows.Forms.ListBox BookList;
        private System.Windows.Forms.TextBox DetailInfoText;
    }
}