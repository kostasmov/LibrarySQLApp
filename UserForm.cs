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
    public partial class UserForm : Form
    {
        User user { get; set; }

        private Form PreviousForm;

        public UserForm(User user, Form PreviousForm)
        {
            this.user = user;
            this.PreviousForm = PreviousForm;

            InitializeComponent();

            nameLabel.Text = user.FullName;
            roleLabel.Text = user.Role;

            if (user.Role == "admin")
            {
                int newWidth = booksPageButton.Size.Width - 20;
                int height = booksPageButton.Size.Height;

                profilePageButton.Size = new Size(newWidth, height);
                booksPageButton.Size = new Size(newWidth, height);
                userFormPageButton.Size = new Size(newWidth, height);
                usersAdminPageButton.Size = new Size(newWidth, height);
                booksAdminPageButton.Size = new Size(newWidth, height);
                issuancePageButton.Size = new Size(newWidth, height);
                reportPageButton.Size = new Size(newWidth, height);
            }
            else
            {
                adminPanel.Hide();
            }
        }

        private void exitLable_Click(object sender, EventArgs e)
        {
            user = null;
            this.Hide();
            PreviousForm.Show();
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
            Application.Exit();
        }
    }
}
