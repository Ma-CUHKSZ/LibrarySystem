using System;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomPage_Load(object sender, EventArgs e)
        {

        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BorrowPic_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            PublicOperations.OpenForm(this, borrow);
        }
    }
}
