using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AParkDispetcher
{
    class Users_list
    {
        private struct C1
        {
            public string tab_number;
            public string name, surname, midname;
            public string login;
            public string password;
            public string role;
        }

        private readonly List<C1> usr = new List<C1>();

        private void FillUser()
        {
            usr.Clear();
            string querry = "USE autos; SELECT user_surname, user_name, user_midname, tab_number, role_title, login FROM users JOIN roles WHERE users.user_role_id = roles.role_id";
            MySqlCommand comm = new MySqlCommand(querry, DbConnection.dbConnect);
            try
            {
                using (MySqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        C1 temp_c = new C1
                        {
                            surname = reader.GetString(0),
                            name = reader.GetString(1),
                            midname = reader.GetString(2),
                            tab_number = reader.GetString(3),
                            role = reader.GetString(4),
                            login = reader.GetString(5)
                        };
                        usr.Add(temp_c);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void FillAdminsUserGrid(DataGridView dgw)
        {
            FillUser();
            for (int i = 0; i < usr.Count; i++)
            {
                dgw.Rows.Add("" + usr[i].surname + " " + usr[i].name + " " + usr[i].midname + "", "" + usr[i].tab_number + "", "" + usr[i].role + "", "" + usr[i].login + "");
            }
        }
    }
}
