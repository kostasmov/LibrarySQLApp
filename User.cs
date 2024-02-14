using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySQLApp
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public string ID { get; set; }
        public string FullName { get; set; }
        public string GroupCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool FineStatus { get; set; }

        public User(string login, string password, string role, int readerID)
        {
            Login = login;
            Password = password;
            Role = role;

            String query = "select * from readers where id=@id;";

            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand(query, DB.getConnection());

            command.Parameters.AddWithValue("@id", readerID);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            ID = table.Rows[0]["id"].ToString();
            FullName =
                table.Rows[0]["first_name"].ToString() + " " + 
                table.Rows[0]["last_name"].ToString();
            GroupCode = table.Rows[0]["group_code"].ToString();
            Phone = table.Rows[0]["phone"].ToString();
            Email = table.Rows[0]["email"].ToString();
            FineStatus = Convert.ToBoolean(table.Rows[0]["fined"]);
        }
    }
}
