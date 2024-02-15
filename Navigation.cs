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
        public static UserStoryForm UserStoryForm { get; set; }

        public static UsersAdminForm UsersAdminForm { get; set; }
        public static BooksAdminForm BooksAdminForm { get; set; }
        public static IssuanceAdminForm IssuanceAdminForm { get; set; }

        public static void CloseUI()
        {
            UserForm.isClosedByCode = true;
            BooksForm.isClosedByCode = true;
            UserStoryForm.isClosedByCode = true;

            UserForm.Close();
            BooksForm.Close();
            UserStoryForm.Close();
        }

        public static void CloseAdmin()
        {
            UsersAdminForm.isClosedByCode = true;
            BooksAdminForm.isClosedByCode = true;
            IssuanceAdminForm.isClosedByCode = true;

            UsersAdminForm.Close();
            BooksAdminForm.Close();
            IssuanceAdminForm.Close();  
        }
    }
}
