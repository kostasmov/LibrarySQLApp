using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibrarySQLApp
{
    public partial class UserForm : Form
    {
        User User { get; set; }

        public bool isClosedByCode = false;

        public UserForm(User user)
        {
            this.User = user;

            InitializeComponent();

            nameLabel.Text = User.FullName;
            roleLabel.Text = User.Role;
            groupLabel.Text = (User.GroupCode != "") ? User.GroupCode : "-";

            loginTextBox.Text = User.Login;
            emailTextBox.Text = User.Email;
            phoneTextBox.Text = User.Phone;

            if (User.Role != "admin")
            {
                adminPanel.Hide();
            }
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

        private void checkSaveButtonEnability()
        {
            if (loginTextBox.Text != User.Login || 
                emailTextBox.Text != User.Email || 
                phoneTextBox.Text != User.Phone)
            {
                SaveButton.Enabled = true;
                SaveButton.BackColor = SystemColors.HotTrack;
            }
            else
            {
                SaveButton.Enabled = false;
                SaveButton.BackColor = Color.LightGray;
            }
            

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(loginTextBox.Text, @"^[A-Za-z0-9_]+$") || loginTextBox.Text == "")
            {
                loginTextBox.ForeColor = Color.Red;
                SaveButton.Enabled = false;
                SaveButton.BackColor = Color.LightGray;
            }
            else if (loginTextBox.Text != User.Login)
            {
                loginTextBox.ForeColor = SystemColors.Highlight;
                checkSaveButtonEnability();
            }
            else
            {
                loginTextBox.ForeColor = Color.Gray;
                checkSaveButtonEnability();
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(emailTextBox.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"))
            {
                emailTextBox.ForeColor = Color.Red;
                SaveButton.Enabled = false;
                SaveButton.BackColor = Color.LightGray;
            }
            else if (emailTextBox.Text != User.Email)
            {
                emailTextBox.ForeColor = SystemColors.Highlight;
                checkSaveButtonEnability();
            }
            else
            {
                emailTextBox.ForeColor = Color.Gray;
                checkSaveButtonEnability();
            }
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(phoneTextBox.Text, @"^\+[0-9]{11,11}$"))
            {
                phoneTextBox.ForeColor = Color.Red;
                SaveButton.Enabled = false;
                SaveButton.BackColor = Color.LightGray;
            }
            else if (phoneTextBox.Text != User.Phone)
            {
                phoneTextBox.ForeColor = SystemColors.Highlight;
                checkSaveButtonEnability();
            }
            else
            {
                phoneTextBox.ForeColor = Color.Gray;
                checkSaveButtonEnability();
            }
        }

        private void newPassTextBox_TextChanged(object sender, EventArgs e)
        {
            if (oldPassTextBox.Text != "" && newPassTextBox.Text != "")
            {
                PassChangeButton.Enabled = true;
                PassChangeButton.BackColor = SystemColors.HotTrack;
            }
            else
            {
                PassChangeButton.Enabled = false;
                PassChangeButton.BackColor = Color.LightGray;
            }
        }

        private void oldPassTextBox_TextChanged(object sender, EventArgs e)
        {
            if (oldPassTextBox.Text != "" && newPassTextBox.Text != "")
            {
                PassChangeButton.Enabled = true;
                PassChangeButton.BackColor = SystemColors.HotTrack;
            }
            else
            {
                PassChangeButton.Enabled = false;
                PassChangeButton.BackColor = Color.LightGray;
            }
        }

        private void PassChangeButton_Click(object sender, EventArgs e)
        {
            if (oldPassTextBox.Text == User.Password)
            {
                String query = 
                    "update accounts " + 
                    "set password=@password " + 
                    "where reader_id=@id;";

                try
                {
                    DB.openConnection();

                    NpgsqlCommand command = new NpgsqlCommand(query, DB.getConnection());

                    command.Parameters.AddWithValue("@id", User.ID);
                    command.Parameters.AddWithValue("@password", newPassTextBox.Text);
                    command.ExecuteNonQuery();

                    Messages.DisplayInfoMessage("Пароль успешно изменён");
                    DB.closeConnection();

                    PassChangeButton.Enabled = false;
                    PassChangeButton.BackColor = Color.LightGray;
                    newPassTextBox.Text = "";
                    oldPassTextBox.Text = "";
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
            else
            {
                Messages.DisplayErrorMessage("Неверный пароль");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            String login = loginTextBox.Text;
            String email = emailTextBox.Text;
            String phone = phoneTextBox.Text;

            String readersQuery =
                "update readers " +
                "set email=@email, phone=@phone " +
                "where id=@id;";

            String accountsQuery =
                "update accounts " +
                "set login=@login " +
                "where reader_id=@id;";

            NpgsqlTransaction transaction = null;

            try
            {
                DB.openConnection();
                transaction = DB.getConnection().BeginTransaction();

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = DB.getConnection();
                command.Transaction = transaction;

                command.CommandText = readersQuery;
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@id", User.ID);
                command.ExecuteNonQuery();

                command.CommandText = accountsQuery;
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@id", User.ID);
                command.ExecuteNonQuery();

                transaction.Commit();
                Messages.DisplayInfoMessage("Данные сохранены.");

                SaveButton.Enabled = false;
                SaveButton.BackColor = Color.LightGray;
                loginTextBox.ForeColor = Color.Gray;
                emailTextBox.ForeColor = Color.Gray;
                phoneTextBox.ForeColor = Color.Gray;

                User.Login = login;
                User.Email = email;
                User.Phone = phone;
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
    }
}
