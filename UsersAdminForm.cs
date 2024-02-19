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
    public partial class UsersAdminForm : Form
    {
        User User { get; set; }

        public bool isClosedByCode = false;

        public UsersAdminForm(User user)
        {
            this.User = user;

            InitializeComponent();

            nameLabel.Text = User.FullName;
            roleLabel.Text = User.Role;            

            CreateGridView();
            LoadGridView();
        }


        private void CreateGridView()
        {
            MainGridView.Columns.Add("login", "Логин");
            MainGridView.Columns.Add("name", "Имя");
            MainGridView.Columns.Add("role", "Роль");
            MainGridView.Columns.Add("group_code", "Группа");
            MainGridView.Columns.Add("email", "Почта");
            MainGridView.Columns.Add("phone", "Телефон");
        }

        private void FillGridRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(
                record.GetString(0),
                record.GetString(1) + " " + record.GetString(2),
                record.GetString(3),
                record.IsDBNull(4) ? "-" : record.GetString(4),
                record.IsDBNull(5) ? "-" : record.GetString(5),
                record.IsDBNull(6) ? "-" : record.GetString(6));
        }

        public void LoadGridView()
        {
            MainGridView.Rows.Clear();

            DataTable dataTable = new DataTable();

            string query = "" +
               "select login, first_name, last_name, role, group_code, email, phone " +
               "from accounts join readers on " +
               "accounts.reader_id = readers.id;";

            DB.openConnection();

            NpgsqlCommand command = new NpgsqlCommand(query, DB.getConnection());
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                FillGridRow(MainGridView, reader);
            }

            DB.closeConnection();

            MainGridView.Sort(MainGridView.Columns["name"], ListSortDirection.Ascending);

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

        private void reportPageButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text.Length > 0)
            {
                MainGridView.Rows.Clear();

                DataTable dataTable = new DataTable();

                string query = $"SELECT login, first_name, last_name, role, group_code, email, phone " +
                    "FROM accounts JOIN readers " +
                    "ON accounts.reader_id = readers.id " +
                    "WHERE accounts.login LIKE '%" + SearchBox.Text + "%' " +
                    "OR accounts.role LIKE '%" + SearchBox.Text + "%' " +
                    "OR readers.first_name LIKE '%" + SearchBox.Text + "%' " +
                    "OR readers.last_name LIKE '%" + SearchBox.Text + "%' " +
                    "OR readers.group_code LIKE '%" + SearchBox.Text + "%' " +
                    "OR readers.email LIKE '%" + SearchBox.Text + "%' " +
                    "OR readers.phone LIKE '%" + SearchBox.Text + "%'";

                DB.openConnection();

                NpgsqlCommand command = new NpgsqlCommand(query, DB.getConnection());
                NpgsqlDataReader reader = command.ExecuteReader();
                command.Parameters.AddWithValue("@text", SearchBox.Text);

                while (reader.Read())
                {
                    FillGridRow(MainGridView, reader);
                }

                DB.closeConnection();

                MainGridView.Sort(MainGridView.Columns["name"], ListSortDirection.Ascending);

                foreach (DataGridViewColumn column in MainGridView.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }

                MainGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                LoadGridView();
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AddUserAdminForm AddUserForm = new AddUserAdminForm(User);
            this.Hide();

            AddUserForm.Show();
            AddUserForm.Location = this.Location;
        }
    }
}
