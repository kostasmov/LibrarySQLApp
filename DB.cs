using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace LibrarySQLApp
{
    public static class DB
    {
        static NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5433; User Id=postgres; Password=0000; Database=library;");


        public static void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public static void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public static NpgsqlConnection getConnection()
        {
            return conn;
        }
    }
}
