using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibrarySystem
{
    public partial class Borrow : Form
    {
        string BookName;
        string[] BookInfo;
        List<string> book_name = new List<string>();
        List<string> book_author = new List<string>();
        List<string> book_publisher = new List<string>();
        List<string> book_isbn = new List<string>();
        List<string> book_price = new List<string>();
        List<string> book_description = new List<string>();

        public Borrow()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            var BookNameL = new List<string>();
            BookNameL.Add(BookName);
            var values = new Dictionary<string, List<string>>
            {
                { "book_name", BookNameL},
            };
            var result = await PublicOperations.NetWork("find_book", values);

            book_name = result["book_name"];
            book_author = result["book_author"];
            book_publisher = result["book_publisher"];
            book_isbn = result["book_isbn"];
            book_price = result["book_price"];
            book_description = result["book_description"];

            int count = book_name.Count;

            BookList.Items.Clear();
            for(int i = 0; i < count; i++)
            {
                string item = "Reserved Book " + i.ToString() + ":  " + book_name[i];
                BookList.Items.Add(item);
            }

        }

        private void Borrow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BookNameText_TextChanged(object sender, EventArgs e)
        {
            BookName = BookNameText.Text;
        }

        private void BookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = BookList.SelectedIndex;
            string[] detailInfo = new string[10];
            detailInfo[0] = "Book Name: " + book_name[index] + "\n";
            detailInfo[1] = "Author: " + book_author[index] + "\n";
            detailInfo[2] = "Publisher: " + book_publisher[index] + "\n";
            detailInfo[3] = "ISBN: " + book_isbn[index] + "\n";
            detailInfo[4] = "Price: " + book_price[index] + "\n";
            detailInfo[8] = "Book Description: " + "\n";
            detailInfo[9] = book_description[index] + "\n";

            DetailInfoText.Lines = detailInfo;
        }

        private async void BorrowButton_Click(object sender, EventArgs e)
        {
            int index = BookList.SelectedIndex;
            string name = book_name[index];
            var nameL = new List<string>();
            nameL.Add(name);
            var values = new Dictionary<string, List<string>>
            {
                { "book_name", nameL},
            };
            var result = await PublicOperations.NetWork("borrow", values);

            if (result["status"][0] == "True")
            {
                DateTime now = DateTime.Now;
                Status.Text = "BORROW SUCCESS\n" + "FROM: " + now + "\n" + "TO: " + now.AddMonths(1);
            }
            else
            {
                Status.Text = "BORROW FAILED!\n" + result["reason"][0];
            }

        }

        private async void ReturnButton_Click(object sender, EventArgs e)
        {
            int index = BookList.SelectedIndex;
            string name = book_name[index];
            var nameL = new List<string>();
            nameL.Add(name);
            var values = new Dictionary<string, List<string>>
            {
                { "book_name", nameL},
            };
            var result = await PublicOperations.NetWork("return", values);
        }
    }
}
