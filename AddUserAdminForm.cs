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
    public partial class AddUserAdminForm : Form
    {
        User User { get; set; }

        public bool isClosedByCode = false;

        public AddUserAdminForm(User user)
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
            String login = loginTextBox.Text;
            String pass = passTextBox.Text;
            String first_name = fnameTextBox.Text;
            String last_name = lnameTextBox.Text;
            String role = roleComboBox.Text;
            String group = groupTextBox.Text;

            if (string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(pass) ||
                string.IsNullOrWhiteSpace(first_name) || 
                string.IsNullOrWhiteSpace(last_name) || 
                string.IsNullOrWhiteSpace(role))
            {
                Messages.DisplayErrorMessage("Заполните все поля");
                return;
            }

            String readersQuery =
                "insert into readers (first_name, last_name, group_code, email, phone) " + 
                "values (@first_name, @last_name, @group, null, null);";

            String accountsQuery =
                "insert into accounts (login, password, role, reader_id) " +
                "values (@login, @pass, @role, @id);";

            NpgsqlTransaction transaction = null;

            try
            {
                DB.openConnection();
                transaction = DB.getConnection().BeginTransaction();

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = DB.getConnection();
                command.Transaction = transaction;

                
                command.CommandText = readersQuery;
                command.Parameters.AddWithValue("@first_name", first_name);
                command.Parameters.AddWithValue("@last_name", last_name);

                if (string.IsNullOrEmpty(group))
                {
                    command.Parameters.AddWithValue("@group", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@group", group);
                }

                command.ExecuteNonQuery();

                command.CommandText = "select lastval();";
                int newUserID = Convert.ToInt32(command.ExecuteScalar());

                command.CommandText = accountsQuery;
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@pass", pass);
                command.Parameters.AddWithValue("@role", role);
                command.Parameters.AddWithValue("@id", newUserID);
                command.ExecuteNonQuery();

                transaction.Commit();
                Messages.DisplayInfoMessage("Пользователь добавлен");

                Navigation.UsersAdminForm.LoadGridView();

                loginTextBox.Text = "";
                passTextBox.Text = "";
                fnameTextBox.Text = "";
                lnameTextBox.Text = "";
                groupTextBox.Text = "";
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                Messages.DisplayErrorMessage($"Ошибка: {ex.Message}");
            }
            finally
            {
                if (transaction != null)
                {
                    transaction.Dispose();
                }
                DB.closeConnection();
            }
        }

        private void getBack_Click(object sender, EventArgs e)
        {
            String login = loginTextBox.Text;
            String pass = passTextBox.Text;
            String first_name = fnameTextBox.Text;
            String last_name = lnameTextBox.Text;
            String group = groupTextBox.Text;

            if (!string.IsNullOrWhiteSpace(login) ||
                !string.IsNullOrWhiteSpace(pass) ||
                !string.IsNullOrWhiteSpace(first_name) ||
                !string.IsNullOrWhiteSpace(last_name) ||
                !string.IsNullOrWhiteSpace(group))
            {
                DialogResult result = Messages.DisplayQuestionMessage("При выходе данные не сохранятся. Продолжить?");
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            isClosedByCode = true;
            this.Close();

            Navigation.UsersAdminForm.Show();
            Navigation.UsersAdminForm.Location = this.Location;
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
