using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySQLApp
{
    public static class Navigation
    {
        public static MainForm MainForm { get; set; }
        public static UserForm UserForm { get; set; }
        public static BooksForm BooksForm { get; set; }

        public static void CloseUI()
        {
            UserForm.isClosedByCode = true;
            BooksForm.isClosedByCode = true;

            UserForm.Close();
            BooksForm.Close();
        }
    }
}
