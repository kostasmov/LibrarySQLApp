﻿using Npgsql;
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

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(loginTextBox.Text, @"^[A-Za-z0-9_]+$") || loginTextBox.Text == "")
            {
                loginTextBox.ForeColor = Color.Red;
            }
            else if (loginTextBox.Text != User.Login)
            {
                SaveButton.Enabled = true;
                SaveButton.BackColor = SystemColors.HotTrack;
                loginTextBox.ForeColor = SystemColors.Highlight;
            }
            else
            {
                loginTextBox.ForeColor = Color.Gray;
                if (emailTextBox.Text == User.Email && phoneTextBox.Text == User.Phone)
                {
                    SaveButton.Enabled = false;
                    SaveButton.BackColor = Color.LightGray;
                }

            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(emailTextBox.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"))
            {
                emailTextBox.ForeColor = Color.Red;
            }
            else if (emailTextBox.Text != User.Email)
            {
                SaveButton.Enabled = true;
                SaveButton.BackColor = SystemColors.HotTrack;
                emailTextBox.ForeColor = SystemColors.Highlight;
            }
            else
            {
                emailTextBox.ForeColor = Color.Gray;
                if (loginTextBox.Text == User.Login && phoneTextBox.Text == User.Phone)
                {
                    SaveButton.Enabled = false;
                    SaveButton.BackColor = Color.LightGray;
                }

            }
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(phoneTextBox.Text, @"^\+[0-9]{11,11}$"))
            {
                phoneTextBox.ForeColor = Color.Red;
            }
            else if (phoneTextBox.Text != User.Phone)
            {
                SaveButton.Enabled = true;
                SaveButton.BackColor = SystemColors.HotTrack;
                phoneTextBox.ForeColor = SystemColors.Highlight;
            }
            else
            {
                phoneTextBox.ForeColor = Color.Gray;
                if (emailTextBox.Text == User.Email && loginTextBox.Text == User.Login)
                {
                    SaveButton.Enabled = false;
                    SaveButton.BackColor = Color.LightGray;
                }

            }
        }

        private void PassChangeButton_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("Транзакция успешно завершена.");
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                Messages.DisplayErrorMessage($"Произошла ошибка: {ex.Message}");
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
