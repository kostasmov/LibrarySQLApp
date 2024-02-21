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
    public partial class IssuanceAdminForm : Form
    {
        User User { get; set; }

        public bool isClosedByCode = false;

        public IssuanceAdminForm(User user)
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
            MainGridView.Columns.Add("title", "Книга");
            MainGridView.Columns.Add("reader", "Читатель");
            MainGridView.Columns.Add("book_date", "Дата выдачи");
            MainGridView.Columns.Add("return_date", "Дата возврата");
            MainGridView.Columns.Add("status", "Состояние");
            MainGridView.Columns.Add("fine", "Штраф");
        }

        private enum Status
        {
            Pending,
            Issued,
            Returned,
            Rejected
        }

        private void FillGridRow(DataGridView dgv, IDataRecord record)
        {
            Dictionary<Status, string> statusMappings = new Dictionary<Status, string>()
            {
                { Status.Pending, "В рассмотре" },
                { Status.Issued, "Выдана" },
                { Status.Returned, "Возвращена" },
                { Status.Rejected, "Отказано" },
            };

            Status status = (Status)Enum.Parse(typeof(Status), record.GetString(5), true);
            string statusText = statusMappings[status];

            dgv.Rows.Add(
                record.GetString(0),
                record.GetString(1) + " " + record.GetString(2),
                record.IsDBNull(3) ? "-" : record.GetDateTime(3).Date.ToString("d"),
                record.IsDBNull(4) ? "-": record.GetDateTime(4).Date.ToString("d"),
                statusText,
                record.GetBoolean(6) ? "✓" : "-");
        }

        public void LoadGridView()
        {
            MainGridView.Rows.Clear();

            DataTable dataTable = new DataTable();

            string query = "" +
                "SELECT books.title, first_name, last_name, " +
                "iss.book_date, iss.return_date, iss.status, fined " +
                "FROM issuance as iss " +
                "join books on iss.book_id = books.id " +
                "join readers on iss.reader_id = readers.id";

            DB.openConnection();

            NpgsqlCommand command = new NpgsqlCommand(query, DB.getConnection());
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                FillGridRow(MainGridView, reader);
            }

            DB.closeConnection();

            MainGridView.Sort(MainGridView.Columns["book_date"], ListSortDirection.Ascending);
        }

        private void exitLable_Click(object sender, EventArgs e)
        {
            isClosedByCode = true;
            Navigation.CloseUI();
            if (User.Role == "admin") { Navigation.CloseAdmin(); }

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

        private void reportPageButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text.Length <= 0)
            {
                LoadGridView();
                return;
            }

            MainGridView.Rows.Clear();

            DataTable dataTable = new DataTable();

            string query = 
                "select b.title, r.first_name, r.last_name, " + 
                "iss.book_date, iss.return_date, iss.status, r.fined " + 
                "from books as b " + 
                "join issuance as iss on b.id = iss.book_id " + 
                "join readers as r on iss.reader_id = r.id " + 
                "where b.title like '%" + SearchBox.Text + "%' or " + 
                "r.first_name like '%" + SearchBox.Text + "%' or " + 
                "r.last_name like '%" + SearchBox.Text + "%';";

            DB.openConnection();

            NpgsqlCommand command = new NpgsqlCommand(query, DB.getConnection());
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                FillGridRow(MainGridView, reader);
            }

            DB.closeConnection();

            MainGridView.Sort(MainGridView.Columns["title"], ListSortDirection.Ascending);
        }
    }
}
