using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySQLApp
{
    public class Navigation
    {
        public MainForm MainForm { get; set; }
        public UserForm UserForm { get; set; }
        public BooksForm BooksForm { get; set; }
        //

        public void CloseUI()
        {
            UserForm.isClosedByCode = true;
            BooksForm.isClosedByCode = true;

            UserForm.Close();
            BooksForm.Close();
        }
    }
}
