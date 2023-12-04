
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrow));
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
            this.splitContainerOfHomePage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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
            this.splitContainerOfHomePage.Size = new System.Drawing.Size(2777, 1167);
            this.splitContainerOfHomePage.SplitterDistance = 924;
            this.splitContainerOfHomePage.SplitterWidth = 6;
            this.splitContainerOfHomePage.TabIndex = 0;
            // 
            // BookList
            // 
            this.BookList.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.BookList.FormattingEnabled = true;
            this.BookList.ItemHeight = 52;
            this.BookList.Location = new System.Drawing.Point(53, 315);
            this.BookList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(804, 316);
            this.BookList.TabIndex = 8;
            this.BookList.SelectedIndexChanged += new System.EventHandler(this.BookList_SelectedIndexChanged);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold);
            this.ReturnButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ReturnButton.Location = new System.Drawing.Point(464, 730);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(395, 63);
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
            this.Status.Location = new System.Drawing.Point(53, 870);
            this.Status.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 57);
            this.Status.TabIndex = 6;
            // 
            // BorrowButton
            // 
            this.BorrowButton.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold);
            this.BorrowButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BorrowButton.Location = new System.Drawing.Point(53, 730);
            this.BorrowButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Size = new System.Drawing.Size(395, 63);
            this.BorrowButton.TabIndex = 4;
            this.BorrowButton.Text = "BORROW";
            this.BorrowButton.UseVisualStyleBackColor = true;
            this.BorrowButton.Click += new System.EventHandler(this.BorrowButton_Click);
            // 
            // BookInfoLabel
            // 
            this.BookInfoLabel.AutoSize = true;
            this.BookInfoLabel.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.BookInfoLabel.Location = new System.Drawing.Point(44, 242);
            this.BookInfoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BookInfoLabel.Name = "BookInfoLabel";
            this.BookInfoLabel.Size = new System.Drawing.Size(406, 49);
            this.BookInfoLabel.TabIndex = 3;
            this.BookInfoLabel.Text = "Book Information";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold);
            this.SearchButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SearchButton.Location = new System.Drawing.Point(613, 140);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(246, 60);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BookNameText
            // 
            this.BookNameText.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.BookNameText.Location = new System.Drawing.Point(53, 140);
            this.BookNameText.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BookNameText.Name = "BookNameText";
            this.BookNameText.Size = new System.Drawing.Size(533, 56);
            this.BookNameText.TabIndex = 1;
            this.BookNameText.TextChanged += new System.EventHandler(this.BookNameText_TextChanged);
            // 
            // ExactSearch
            // 
            this.ExactSearch.AutoSize = true;
            this.ExactSearch.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExactSearch.Location = new System.Drawing.Point(44, 69);
            this.ExactSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ExactSearch.Name = "ExactSearch";
            this.ExactSearch.Size = new System.Drawing.Size(287, 49);
            this.ExactSearch.TabIndex = 0;
            this.ExactSearch.Text = "ExactSearch";
            // 
            // DetailInfoText
            // 
            this.DetailInfoText.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.DetailInfoText.Location = new System.Drawing.Point(45, 140);
            this.DetailInfoText.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DetailInfoText.Multiline = true;
            this.DetailInfoText.Name = "DetailInfoText";
            this.DetailInfoText.Size = new System.Drawing.Size(567, 920);
            this.DetailInfoText.TabIndex = 4;
            // 
            // PictureLabel
            // 
            this.PictureLabel.AutoSize = true;
            this.PictureLabel.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.PictureLabel.Location = new System.Drawing.Point(653, 64);
            this.PictureLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(269, 49);
            this.PictureLabel.TabIndex = 3;
            this.PictureLabel.Text = "Book Cover";
            // 
            // BookCover
            // 
            this.BookCover.Image = global::LibrarySystem.Properties.Resources.Coverage;
            this.BookCover.Location = new System.Drawing.Point(663, 140);
            this.BookCover.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BookCover.Name = "BookCover";
            this.BookCover.Size = new System.Drawing.Size(947, 922);
            this.BookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BookCover.TabIndex = 2;
            this.BookCover.TabStop = false;
            // 
            // BookDetailInfo
            // 
            this.BookDetailInfo.AutoSize = true;
            this.BookDetailInfo.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.BookDetailInfo.Location = new System.Drawing.Point(39, 64);
            this.BookDetailInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BookDetailInfo.Name = "BookDetailInfo";
            this.BookDetailInfo.Size = new System.Drawing.Size(473, 49);
            this.BookDetailInfo.TabIndex = 0;
            this.BookDetailInfo.Text = "Detailed Information";
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2579, 1167);
            this.Controls.Add(this.splitContainerOfHomePage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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