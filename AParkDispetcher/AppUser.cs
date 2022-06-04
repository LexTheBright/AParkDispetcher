using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace AParkDispetcher
{
    class AppUser
    {
        public static string tabNum { get; private set; }
        public static string name { get; private set; }
        public static string secondName { get; private set; }
        public static string thirdName { get; private set; }

        public static string roleTitle;
        public string login { get; private set; }

        private int roleID;
        private string password;
        
        public static bool iSsignedIn { get; private set; } 

        private static AppUser connInstance;

        private AppUser() {
        }
        
        public static AppUser getConnInstance()
        {
            if (connInstance == null) connInstance = new AppUser();
            return connInstance;
        }

        public void tryToLogin(string textlogin, string textPassword)
        {
            string querry = $"USE autos; SELECT * from users where login = '{textlogin}'";
            MySqlCommand commLine = new MySqlCommand(querry, dbConnection.dbConnect);
            try
            {
                using (MySqlDataReader reader = commLine.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tabNum = reader.GetString(0);
                        name = reader.GetString(2);
                        secondName = reader.GetString(1);
                        thirdName = reader.GetString(3);
                        login = reader.GetString(4);
                        password = reader.GetString(5);
                        roleID = reader.GetInt32(6);
                        roleTitle = getRoleTitle(roleID);
                    }
                    else
                    {
                        MessageBox.Show("Пользователя с таким логином\\паролем не существует.1");
                        iSsignedIn = false;
                        return;
                    }
                }
            }
            catch (MySqlException e)
            {
                string ErrMessageText = getErrorMessage(e.Number);
                if (ErrMessageText == "") throw;
                else MessageBox.Show(ErrMessageText);
                iSsignedIn = false;
                return;
            }
            using (SHA256 mySHA256 = SHA256.Create())
            {
                if (password != BitConverter.ToString(mySHA256.ComputeHash(Encoding.UTF8.GetBytes(textPassword))).Replace("-", "").Substring(0, 32))
                {
                    MessageBox.Show("Пользователя с таким логином\\паролем не существует.2");
                    iSsignedIn = false;
                    return;
                }
                else
                {
                    iSsignedIn = true;
                }
            }
        }

        private string getErrorMessage(int ErrorNumber)
        {
            switch (ErrorNumber)
            {
                case 1062:
                    return "";
                default:
                    return "";
            }
        }

        public static void LogOut()
        {
            iSsignedIn = false;
        }

        private string getRoleTitle(int role)
        {
            switch (role)
            {
                case 0: return "Пользователь"; break;
                case 1: return "Оператор"; break;
                case 2: return "Администратор"; break;
                default:
                    return ""; break;
            }
        }
    }
}
