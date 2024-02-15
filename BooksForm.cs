using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySQLApp
{
    public partial class BooksForm : Form
    {
        User User { get; set; }

        public bool isClosedByCode = false;

        public BooksForm(User user)
        {
            this.User = user;

            InitializeComponent();

            nameLabel.Text = User.FullName;
            roleLabel.Text = User.Role;

            if (User.Role != "admin")
            {
                adminPanel.Hide();
            }
        }

        private void exitLable_Click(object sender, EventArgs e)
        {
            isClosedByCode = true;
            User = null;
            Navigation.MainForm.Location = this.Location;
            Navigation.CloseUI();
            Navigation.MainForm.Show();
            Navigation.MainForm.Location = this.Location;
        }

        private void exitLable_MouseEnter(object sender, EventArgs e)
        {
            exitLable.ForeColor = Color.Black;
        }

        private void exitLable_MouseLeave(object sender, EventArgs e)
        {
            exitLable.ForeColor = Color.DimGray;
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClosedByCode)
            {
                Application.Exit();
            }
        }

        private void profilePageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation.UserForm.Show();
            Navigation.UserForm.Location = this.Location;
        }

        private void booksPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation.BooksForm.Show();
            Navigation.BooksForm.Location = this.Location;
        }

        private void userFormPageButton_Click(object sender, EventArgs e)
        {

        }

        private void usersAdminPageButton_Click(object sender, EventArgs e)
        {

        }

        private void booksAdminPageButton_Click(object sender, EventArgs e)
        {

        }

        private void issuancePageButton_Click(object sender, EventArgs e)
        {

        }

        private void reportPageButton_Click(object sender, EventArgs e)
        {

        }
    }
}
