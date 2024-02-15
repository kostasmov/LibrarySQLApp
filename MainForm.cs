using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibrarySQLApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            String login = loginField.Text;
            String password = passField.Text;

            if (login == "" || password == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            String query = 
                "select * from accounts " + 
                "where login=@login and password=@password;";

            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand(query, DB.getConnection());

            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                loginField.Text = "";
                passField.Text = "";

                String role = table.Rows[0]["role"].ToString();
                int readerID = (int)table.Rows[0]["reader_id"];

                Navigation navigator = new Navigation();
                User user = new User(login, password, role, readerID);

                navigator.MainForm = this;
                navigator.UserForm = new UserForm(user, navigator);
                navigator.BooksForm = new BooksForm(user, navigator);
                // ЕЩЁ!

                this.Hide();
                navigator.UserForm.Show();
            }
            else
                Messages.DisplayErrorMessage("Неверный логин или пароль.");

            //
        }
    }
}
