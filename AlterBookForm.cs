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
    public partial class AlterBookForm : Form
    {
        User User { get; set; }
        DataGridViewRow Row { get; set; }

        public bool isClosedByCode = false;

        public AlterBookForm(User user, DataGridViewRow row)
        {
            this.User = user;
            this.Row = row;

            InitializeComponent();

            nameLabel.Text = User.FullName;
            roleLabel.Text = User.Role;

            FillBookData();
            PrintAuthors();
        }

        public void FillBookData()
        {
            titleBox.Text = Row.Cells[0].Value.ToString();
            publisherBox.Text = Row.Cells[1].Value.ToString();
            yearBox.Text = Row.Cells[2].Value.ToString();
            typeBox.Text = Row.Cells[3].Value.ToString();
            amountBox.Text = Row.Cells[4].Value.ToString();
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
                    "update books set " +
                    "title = @title, " +
                    "publisher = @publisher, " +
                    "book_year = @year, " +
                    "amount = @amount, " +
                    "type = @type " +
                    "where id = @id";

                DB.openConnection();

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = DB.getConnection();
    
                command.CommandText = query;
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@publisher", publisher);
                command.Parameters.AddWithValue("@amount", amount);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@id", (int)Row.Cells[6].Value);

                command.ExecuteNonQuery();

                Messages.DisplayInfoMessage("Данные обновлены");
                Navigation.BooksAdminForm.LoadGridView();
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

            if (result == DialogResult.No)
            {
                return;
            }

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

        public void PrintAuthors()
        {
            string query = "" +
                "select first_name, last_name from authors " +
                "join book_author as ba on ba.author_id = authors.id " +
                "join books on books.id = ba.book_id " +
                "where books.id = @id";

            List<string> authors = new List<string>();

            DB.openConnection();

            NpgsqlCommand command = new NpgsqlCommand(query, DB.getConnection());
            command.Parameters.AddWithValue("@id", (int)Row.Cells[6].Value);
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                authors.Add(reader.GetString(0)[0] + ". " + reader.GetString(1));
            }

            DB.closeConnection();

            authorsList.Text = string.Join(", ", authors);
        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            String first_name = firstNameBox.Text;
            String last_name = lastNameBox.Text;

            String authorsQuery =
                "insert into authors (first_name, last_name) " +
                "select @fname, @lname where not exists " +
                "(select 1 from authors " +
                "where first_name = @fname and " +
                "last_name = @lname);";

            String searchQuery =
                "select id from authors " +
                "where first_name = @fname and " +
                "last_name = @lname";
            
            String book_authorQuery =
                "insert into book_author " +
                "values (@b_id, @a_id)";

            if (string.IsNullOrWhiteSpace(first_name) || 
                string.IsNullOrWhiteSpace(last_name))
            {
                Messages.DisplayErrorMessage("Заполните все поля");
                return;
            }

            try
            {
                DB.openConnection();

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = DB.getConnection();

                command.CommandText = authorsQuery;
                command.Parameters.AddWithValue("@fname", first_name);
                command.Parameters.AddWithValue("@lname", last_name);

                command.ExecuteNonQuery();

                command.CommandText = searchQuery;
                command.Parameters.AddWithValue("@fname", first_name);
                command.Parameters.AddWithValue("@lname", last_name);

                int newAuthorID = Convert.ToInt32(command.ExecuteScalar());

                command.CommandText = book_authorQuery;
                command.Parameters.AddWithValue("@b_id", (int)Row.Cells[6].Value);
                command.Parameters.AddWithValue("@a_id", newAuthorID);

                command.ExecuteNonQuery();
                PrintAuthors();
                Navigation.BooksAdminForm.PrintAuthors();

                firstNameBox.Text = string.Empty;
                lastNameBox.Text = string.Empty;

                Messages.DisplayInfoMessage("Автор добавлен");
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
    }
}
