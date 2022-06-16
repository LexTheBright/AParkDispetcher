using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AParkDispetcher
{
    /// <summary>
    ///  Класс для выполнения соединения с БД 
    /// </summary>      
    public class DbConnection
    {
        public static string username = "root";
        public static string password = "admin";
        public static string dbName = "autos";
        private static MySqlConnection myConnection;
        // Поле для создания или обращения к уже существующему объекту (соединению)
        public static MySqlConnection dbConnect
        {
            get
            {
                // если это первое соединение
                if (myConnection == null)
                {
                    try
                    {
                        myConnection = new MySqlConnection(@"Server= localhost;Database=" + dbName + ";port=3306;User Id=" + username + ";password=" + password + ";charset=utf8");
                        myConnection.Open();
                    }
                    catch (Exception e)
                    {
                        myConnection = null;
                        MessageBox.Show("Невозможно установить соединение с сервером!\n\n" + e.Message, "Ошибка соединения");
                    }
                }
                return myConnection;
            }
        }
    }
}

