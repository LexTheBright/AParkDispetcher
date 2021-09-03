using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AParkDispetcher
{
    /// <summary>
    ///  Класс для выполнения соединения с БД 
    /// </summary>      
    public class dbConnection
    {
        public static string username = "root";
        public static string password = "admin";
        public static string dbName = "autos";
        //public static MySqlConnection myConnection;
        public static MySqlConnection myConnection;
        // Метод для создания или обращения к уже существующему объекту (соединению)
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
                    catch (Exception)
                    {
                        myConnection = null;
                        throw;
                    }
                }
                return myConnection;
            }
        }
    }
}
