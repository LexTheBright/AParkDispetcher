using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AParkDispetcher
{
    class AppUser
    {
        public static string TabNum { get; private set; }
        public static string Name { get; private set; }
        public static string SecondName { get; private set; }
        public static string ThirdName { get; private set; }

        public static string roleTitle;
        public string Login { get; private set; }

        private int roleID;
        private string password;

        public static bool ISsignedIn { get; private set; }

        private static AppUser connInstance;
        public static AppUser getConnInstance()
        {
            if (connInstance == null) connInstance = new AppUser();
            return connInstance;
        }

        public void TryToLogin(string textlogin, string textPassword)
        {
            ISsignedIn = false;
            string querry = $"USE autos; SELECT * from users where login = '{textlogin}'";
            MySqlCommand commLine = new MySqlCommand(querry, DbConnection.dbConnect);
            try
            {
                using (MySqlDataReader reader = commLine.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        TabNum = reader.GetString(0);
                        Name = reader.GetString(2);
                        SecondName = reader.GetString(1);
                        ThirdName = reader.GetString(3);
                        Login = reader.GetString(4);
                        password = reader.GetString(5);
                        roleID = reader.GetInt32(6);
                        roleTitle = GetRoleTitle(roleID);
                    }
                    else
                    {
                        MessageBox.Show("Пользователя с таким логином\\паролем не существует.", "Ошибка авторизации пользователя");
                        return;
                    }
                }
            }
            catch (MySqlException e)
            {
                string ErrMessageText = GetErrorMessage(e.Number);
                if (ErrMessageText == "") throw;
                else MessageBox.Show(ErrMessageText);
                return;
            }
            using (SHA256 mySHA256 = SHA256.Create())
            {
                if (password != BitConverter.ToString(mySHA256.ComputeHash(Encoding.UTF8.GetBytes(textPassword))).Replace("-", "").Substring(0, 32))
                {
                    MessageBox.Show("Пользователя с таким логином\\паролем не существует.", "Ошибка авторизации пользователя");
                    return;
                }
                else
                {
                    ISsignedIn = true;
                }
            }
        }

        private string GetErrorMessage(int ErrorNumber)
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
            ISsignedIn = false;
        }

        private string GetRoleTitle(int role)
        {
            switch (role)
            {
                case 0: return "Пользователь"; 
                case 1: return "Оператор";
                case 2: return "Администратор";
                case 3: return "Начальник АХЧ";
                default:
                    return "";
            }
        }
    }
}
