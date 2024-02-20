using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySQLApp
{
    public partial class AddBookForm : Form
    {
        User User { get; set; }

        public bool isClosedByCode = false;

        public AddBookForm(User user)
        {
            this.User = user;

            InitializeComponent();

            nameLabel.Text = User.FullName;
            roleLabel.Text = User.Role;
        }

        private void exitLable_Click(object sender, EventArgs e)
        {
            isClosedByCode = true;
            this.Close();

            Navigation.CloseUI();
            if (User.Role == "admin") Navigation.CloseAdmin();

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
            if (!this.isClosedByCode)
            {
                Application.Exit();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                String title = titleBox.Text;
                String publisher = publisherBox.Text;
                int year = int.Parse(yearBox.Text);
                int amount = int.Parse(amountBox.Text);
                String type = typeBox.Text;

                if (string.IsNullOrWhiteSpace(title) ||
                    string.IsNullOrWhiteSpace(publisher) ||
                    string.IsNullOrWhiteSpace(type))
                {
                    Messages.DisplayErrorMessage("Заполните все поля");
                    return;
                }

                String query =
                    "insert into books " +
                    "(title, publisher, book_year, amount, type) " +
                    "values (@title, @publisher, @year, @amount, @type)";

                DB.openConnection();

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = DB.getConnection();
    
                command.CommandText = query;
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@publisher", publisher);
                command.Parameters.AddWithValue("@amount", amount);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@type", type);

                command.ExecuteNonQuery();

                Messages.DisplayInfoMessage("Книга добавлена");
                Navigation.BooksAdminForm.LoadGridView();

                titleBox.Text = string.Empty;
                publisherBox.Text = string.Empty;
                amountBox.Text = string.Empty;
                typeBox.Text = string.Empty;
                yearBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Messages.DisplayErrorMessage($"Ошибка: {ex.Message}");
            }
            finally
            {
                DB.closeConnection();
            }
        }

        private void getBack_Click(object sender, EventArgs e)
        {
            DialogResult result = Messages.DisplayQuestionMessage(
                "Возможно, при выходе некоторые данные не сохранятся. Продолжить?");

            if (result == DialogResult.No) { return; }

            isClosedByCode = true;
            this.Close();

            Navigation.BooksAdminForm.Show();
            Navigation.BooksAdminForm.Location = this.Location;
        }

        private void getBack_MouseEnter(object sender, EventArgs e)
        {
            getBack.BackColor = Color.LightGray;
        }

        private void getBack_MouseLeave(object sender, EventArgs e)
        {
            getBack.BackColor = SystemColors.Control;
        }
    }
}
