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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            MainGridView.Columns.Add("id", "ID");

            MainGridView.Columns["id"].Visible = false;
        }

        private void FillGridRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(
                record.GetString(0),
                record.GetString(1) + " " + record.GetString(2),
                record.IsDBNull(3) ? "-" : record.GetDateTime(3).Date.ToString("d"),
                record.IsDBNull(4) ? "-": record.GetDateTime(4).Date.ToString("d"),
                record.GetString(5),
                record.GetBoolean(6) ? "✓" : "-",
                record.GetInt32(7));
        }

        public void LoadGridView()
        {
            MainGridView.Rows.Clear();

            DataTable dataTable = new DataTable();

            string query = "" +
                "SELECT title, first_name, last_name, iss.book_date, " +
                "iss.return_date, iss.status, fined, iss.id " +
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

            MainGridView.Sort(MainGridView.Columns["book_date"], ListSortDirection.Descending);
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
                "iss.book_date, iss.return_date, iss.status, r.fined, iss.id " + 
                "from books as b " + 
                "join issuance as iss on b.id = iss.book_id " + 
                "join readers as r on iss.reader_id = r.id " + 
                "where b.title like '%" + SearchBox.Text + "%' or " + 
                "r.first_name like '%" + SearchBox.Text + "%' or " +
                "iss.status like '%" + SearchBox.Text + "%' or " +
                "r.last_name like '%" + SearchBox.Text + "%';";

            DB.openConnection();

            NpgsqlCommand command = new NpgsqlCommand(query, DB.getConnection());
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                FillGridRow(MainGridView, reader);
            }

            DB.closeConnection();

            MainGridView.Sort(MainGridView.Columns["book_date"], ListSortDirection.Descending);
        }

        private void SetButton(System.Windows.Forms.Button button, Boolean IsEnabled)
        {
            if (IsEnabled)
            {
                button.Enabled = true;
                button.BackColor = SystemColors.Highlight;
            }
            else
            {
                button.Enabled = false;
                button.BackColor = Color.LightGray;
            }
        }

        private void UpdateButtons()
        {
            SetButton(rejectButton, false);
            SetButton(returnButton, false);
            SetButton(fineButton, false);
            SetButton(issueButton, false);

            if (MainGridView.CurrentCell == null)
            {
                return;
            }

            DataGridViewRow row = MainGridView.Rows[MainGridView.CurrentCell.RowIndex];
            String status = row.Cells[4].Value.ToString();

            if (status == "pending")
            {
                SetButton(rejectButton, true);
                SetButton(issueButton, true);
            }
            else if (status == "issued")
            {
                SetButton(returnButton, true);
                SetButton(fineButton, true);
            }

            return;
        }

        private void MainGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateButtons();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            NpgsqlTransaction transaction = null;

            try
            {
                DataGridViewRow row = MainGridView.Rows[MainGridView.CurrentCell.RowIndex];
                int id = (int)row.Cells[6].Value;

                string issueQuery = "" +
                    "update issuance " +
                    "set status = 'returned', " +
                    "return_date = CURRENT_DATE " +
                    "where id = @id";

                string readerQuery = "" +
                    "update readers " +
                    "set fined = false " +
                    "WHERE id = " +
                    "(select reader_id from issuance " +
                    "where id = @id); ";

                DB.openConnection();

                NpgsqlCommand command1 = new NpgsqlCommand(issueQuery, DB.getConnection());
                transaction = DB.getConnection().BeginTransaction(); ;

                command1.Parameters.AddWithValue("@id", id);
                command1.ExecuteNonQuery();

                NpgsqlCommand command = new NpgsqlCommand(readerQuery, DB.getConnection());
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

                transaction.Commit();

                DB.closeConnection();

                LoadGridView();
                UpdateButtons();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Messages.DisplayErrorMessage(ex.Message);
            }

            transaction.Dispose();
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = MainGridView.Rows[MainGridView.CurrentCell.RowIndex];
            int id = (int)row.Cells[6].Value;

            string query = "" +
                "update issuance " +
                "set status = 'rejected' " +
                "where id = @id";

            DB.openConnection();

            NpgsqlCommand command = new NpgsqlCommand(query, DB.getConnection());
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();

            DB.closeConnection();

            LoadGridView();
            UpdateButtons();
        }

        private void issueButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = MainGridView.Rows[MainGridView.CurrentCell.RowIndex];
            int id = (int)row.Cells[6].Value;

            string query = "" +
                "update issuance " +
                "set status = 'issued', " +
                "book_date = CURRENT_DATE, " +
                "return_date = CURRENT_DATE + INTERVAL '1 month' " +
                "where id = @id";

            DB.openConnection();

            NpgsqlCommand command = new NpgsqlCommand(query, DB.getConnection());
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();

            DB.closeConnection();

            LoadGridView();
            UpdateButtons();
        }

        private void fineButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = MainGridView.Rows[MainGridView.CurrentCell.RowIndex];
            int id = (int)row.Cells[6].Value;

            DateTime endDate = DateTime.Parse(row.Cells[3].Value.ToString());
            DateTime currentDate = DateTime.Now;

            if (currentDate < endDate) 
            {
                Messages.DisplayErrorMessage("Срок выдачи ещё не истёк!");
                return;
            }

            string readerQuery = "" +
                "update readers " +
                "set fined = true " +
                "WHERE id = " +
                "(select reader_id from issuance " +
                "where id = @id); ";

            DB.openConnection();

            NpgsqlCommand command = new NpgsqlCommand(readerQuery, DB.getConnection());
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            DB.closeConnection();

            LoadGridView();
            UpdateButtons();
        }

        private void IssuanceAdminForm_Activated(object sender, EventArgs e)
        {
            LoadGridView();
        }
    }
}
