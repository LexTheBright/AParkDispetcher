using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AParkDispetcher
{
    class AdminDBRedactor
    {

        public void deleteByID(string table, string id_title, string id)
        {
            string querry = "";
            querry = $"USE autos; DELETE FROM {table} WHERE {id_title} = {id}";
            MySqlCommand comm = new MySqlCommand(querry, dbConnection.dbConnect);
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            
            comm.Connection.Close();
        }

        public void updateByID(string table, string id_title, string id, Dictionary<string, string> props)
        {
            string querry = "";
            string adding = "";

            foreach (var prop in props)
            {
                adding += $"{prop.Key} = '{prop.Value}', ";
            }

            adding = adding.Remove(adding.Length - 2);

            querry = $"USE autos; UPDATE {table} SET " + adding +
                $" WHERE {id_title} = {id}";

            MySqlCommand comm = new MySqlCommand(querry, dbConnection.dbConnect);
            try
            {
                comm.ExecuteNonQuery();
                //MessageBox.Show("ОБНОВИЛОСЯ!!!!!!");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
