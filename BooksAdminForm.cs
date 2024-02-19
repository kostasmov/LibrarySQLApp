using Npgsql;
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
    public partial class BooksAdminForm : Form
    {
        User User { get; set; }

        public bool isClosedByCode = false;

        public BooksAdminForm(User user)
        {
            this.User = user;

            InitializeComponent();

            nameLabel.Text = User.FullName;
            roleLabel.Text = User.Role;            

            if (User.Role != "admin")
            {
                adminPanel.Hide();
            }

            CreateGridView();
            LoadGridView();
        }

        private void CreateGridView()
        {
            MainGridView.Columns.Add("title", "Название");
            //MainGridView.Columns.Add("author", "Автор");
            MainGridView.Columns.Add("publisher", "Издатель");
            MainGridView.Columns.Add("year", "Год");
            MainGridView.Columns.Add("type", "Тип");
            MainGridView.Columns.Add("amount", "Всего");
            MainGridView.Columns.Add("issued", "Выдано");
        }

        private void FillGridRow(DataGridView dgv, IDataRecord record)
        {
            /*string query = "" + 
                "select first_name, last_name from authors " + 
                "join book_authors as ba on ba.author_id = authors.id " + 
                "join books on books.id = ba.book_id " + 
                "where books.id = @id;";

            List<string> authors = new List<string>();

            NpgsqlCommand command1 = new NpgsqlCommand(query, DB.getConnection());
            command1.Parameters.AddWithValue("@id", record.GetInt32(6));
            NpgsqlDataReader reader = command1.ExecuteReader();
            
            while (reader.Read())
            {
                authors.Add(reader.GetString(0) + " " + reader.GetString(1));
            }

            string authorText = "";

            if (authors.Count == 1)
            {
                authorText = authors[0];
            }
            else if (authors.Count > 1)
            {
                authorText = authors[0] + " и др.";
            }*/

            dgv.Rows.Add(
                record.GetString(0),
                //authorText,
                record.GetString(1),
                record.GetInt32(2),
                (record.GetString(3) == "fiction") ? "худ." : "науч.",
                record.GetInt32(4),
                record.GetInt32(5));
        }

        public void LoadGridView()
        {
            MainGridView.Rows.Clear();

            DataTable dataTable = new DataTable();

            string query = 
                "select books.title, publisher, book_year, type, amount, issued_amount, books.id " +
                "from books join books_amount as ba on ba.id = books.id;";

            DB.openConnection();

            NpgsqlCommand command = new NpgsqlCommand(query, DB.getConnection());
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                FillGridRow(MainGridView, reader);
            }

            DB.closeConnection();

            MainGridView.Sort(MainGridView.Columns["title"], ListSortDirection.Ascending);

            foreach (DataGridViewColumn column in MainGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            MainGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void exitLable_Click(object sender, EventArgs e)
        {
            isClosedByCode = true;
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

        private void userStoryPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation.UserStoryForm.Show();
            Navigation.UserStoryForm.Location = this.Location;
        }

        private void usersAdminPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation.UsersAdminForm.Show();
            Navigation.UsersAdminForm.Location = this.Location;
        }

        private void booksAdminPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation.BooksAdminForm.Show();
            Navigation.BooksAdminForm.Location = this.Location;
        }

        private void issuancePageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation.IssuanceAdminForm.Show();
            Navigation.IssuanceAdminForm.Location = this.Location;
        }


    }
}
