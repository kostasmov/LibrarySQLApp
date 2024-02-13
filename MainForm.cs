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
            NpgsqlCommand command = new NpgsqlCommand(query, DB.GetConnection());

            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Авторизация пройдена!");
            else
                Messages.DisplayErrorMessage("Неверный логин или пароль.");
        }
    }
}
