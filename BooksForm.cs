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

            CreateGridView();
            LoadGridView();

            if (User.Role != "admin")
            {
                adminPanel.Hide();
            }
        }

        private void CreateGridView()
        {
            MainGridView.Columns.Add("title", "Название");
            MainGridView.Columns.Add("publisher", "Издатель");
            MainGridView.Columns.Add("year", "Год");
            MainGridView.Columns.Add("type", "Тип");
            MainGridView.Columns.Add("id", String.Empty);

            MainGridView.Columns["id"].Visible = false;
        }

        private void FillGridRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(
                record.GetString(0),
                record.GetString(1),
                record.GetInt32(2),
                record.GetString(3),
                record.GetInt32(4));
        }

        public void LoadGridView()
        {
            MainGridView.Rows.Clear();

            DataTable dataTable = new DataTable();

            string query = 
                "select books.title, publisher, book_year, type, books.id " +
                "from books join books_amount as ba on ba.id = books.id " +
                "where ba.available_amount > 0;";

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

            MainGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            PrintAuthors();
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

        private void MainGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PrintAuthors();
        }

        public void PrintAuthors()
        {
            DataGridViewRow row;

            if (MainGridView.CurrentCell != null)
            {
                row = MainGridView.Rows[MainGridView.CurrentCell.RowIndex];
            }
            else
            {
                row = MainGridView.Rows[0];
            }

            string query = "" +
                "select first_name, last_name from authors " +
                "join book_author as ba on ba.author_id = authors.id " +
                "join books on books.id = ba.book_id " +
                "where books.id = @id";

            List<string> authors = new List<string>();

            DB.openConnection();

            NpgsqlCommand command = new NpgsqlCommand(query, DB.getConnection());
            command.Parameters.AddWithValue("@id", (int)row.Cells[4].Value);
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                authors.Add(reader.GetString(0) + " " + reader.GetString(1));
            }

            DB.closeConnection();

            authorsList.Text = string.Join(", ", authors);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text.Length <= 0)
            {
                LoadGridView();
                PrintAuthors();
                return;
            }

            MainGridView.Rows.Clear();

            DataTable dataTable = new DataTable();

            string query =
                "select distinct b.title, publisher, book_year, type, b.id " +
                "from books as b " +
                "join book_author as ban on b.id = ban.book_id " +
                "join authors as a on ban.author_id = a.id " +
                "join books_amount as bam on b.id = bam.id " +
                "where b.title like '%" + SearchBox.Text + "%' or " +
                "b.publisher like '%" + SearchBox.Text + "%' or " +
                "a.first_name like '%" + SearchBox.Text + "%' or " +
                "a.last_name like '%" + SearchBox.Text + "%';";

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

            MainGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (MainGridView.CurrentCell != null)
            {
                PrintAuthors();
                return;
            }

            authorsList.Text = "выберите книгу";
        }

        private void BooksForm_Activated(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;

            if (MainGridView.CurrentCell == null)
            {
                Messages.DisplayErrorMessage("Выберите книгу!");
                return;
            }

            row = MainGridView.Rows[MainGridView.CurrentCell.RowIndex];

            string countQuery = "" +
                "select count(*) from issuance " +
                "where reader_id = @id and " +
                "status = @status;";

            DB.openConnection();

            NpgsqlCommand command = new NpgsqlCommand(countQuery, DB.getConnection());
            command.Parameters.AddWithValue("@id", User.ID);
            command.Parameters.AddWithValue("@status", "issued");

            object result = command.ExecuteScalar();
            int issued = (result != null) ? Convert.ToInt32(result) : 0;

            command = new NpgsqlCommand(countQuery, DB.getConnection());
            command.Parameters.AddWithValue("@id", User.ID);
            command.Parameters.AddWithValue("@status", "pending");

            result = command.ExecuteScalar();
            int pending = (result != null) ? Convert.ToInt32(result) : 0;

            DB.closeConnection();

            if (issued != 0)
            {
                Messages.DisplayErrorMessage("" +
                    "Невозможно оформить заявку. Имеются невозвращённые книги");
                return;
            }

            if (pending > 2)
            {
                Messages.DisplayErrorMessage("" +
                    "Предел заявок от читателя достиг предела. " +
                    "Дождитесь ответа администратора.");
                return;
            }

            string insertQuery = "" +
                "insert into issuance (book_id, reader_id, status) " + 
                "select @book_id, @reader_id, 'pending' " + 
                "where not exists (select 1 from issuance where book_id = " +
                "@book_id and reader_id = @reader_id and status = 'pending');";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(insertQuery, DB.getConnection());
                command.Parameters.AddWithValue("@book_id", (int)row.Cells[4].Value);
                command.Parameters.AddWithValue("@reader_id", User.ID);

                command.ExecuteNonQuery();

                DB.closeConnection();

                Messages.DisplayInfoMessage("Заявка успешно отправлена");
                Navigation.UserStoryForm.LoadGridView();
            }
            catch (Exception ex)
            {
                Messages.DisplayErrorMessage(ex.Message);
            }
        }
    }
}
