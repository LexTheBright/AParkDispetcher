using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AParkDispetcher
{
    class Drivers_list
    {
        public struct C1
        {
            public string tab_number;
            public string name, surname, midname;
            public int state;
            /*public string TitleState;*/
        }


        public List<C1> usr = new List<C1>();

        public void fillDriver()
        {
            usr.Clear();
            string querry = "";
            querry = "USE autos; SELECT driver_surname, driver_name,  driver_midname, tab_number, driver_state FROM drivers ORDER BY driver_state";
            MySqlCommand comm = new MySqlCommand(querry, DbConnection.dbConnect);
            try
            {
                using (MySqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        C1 temp_c = new C1();
                        temp_c.surname = reader.GetString(0);
                        temp_c.name = reader.GetString(1);
                        temp_c.midname = reader.GetString(2);
                        temp_c.tab_number = reader.GetString(3);
                        temp_c.state = reader.GetInt32(4);
                        usr.Add(temp_c);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void fillSelectDriverForm(DataGridView dgw)
        {
            fillDriver();
            for (int i = 0; i < usr.Count; i++)
            {
                dgw.Rows.Add("" + usr[i].surname + " " + usr[i].name + " " + usr[i].midname + "", "" + usr[i].tab_number + "", "" + StateTitle(usr[i].state) + "");
                //if (usr[i].state == 0) dgw.CurrentRow.Cells[4].Style.BackColor = System.Drawing.Color.Green;
            }
        }

        public void fillAdminsDriverGrid(DataGridView dgw)
        {
            fillDriver();
            for (int i = 0; i < usr.Count; i++)
            {
                dgw.Rows.Add("" + usr[i].surname + " " + usr[i].name + " " + usr[i].midname + "", "" + usr[i].tab_number + "", "" + StateTitle(usr[i].state) + "");
                //if (usr[i].state == 0) dgw.CurrentRow.Cells[4].Style.BackColor = System.Drawing.Color.Green;
            }
        }

        public void fillDispatchersDriverGrid(DataGridView dgw)
        {
            fillDriver();
            for (int i = 0; i < usr.Count; i++)
            {
                dgw.Rows.Add("" + usr[i].surname + " " + usr[i].name + " " + usr[i].midname + "", "" + usr[i].state + "", "" + usr[i].tab_number + "");
                //if (usr[i].state == 0) dgw.CurrentRow.Cells[4].Style.BackColor = System.Drawing.Color.Green;
            }
        }


        public string StateTitle(int state)
        {
            switch (state)
            {
                case 0:
                    return "Работает";
                case 1:
                    return "Занят";
                case 2:
                    return "Отсутствует";
                default:
                    return "Неизвестное состояние";
            }
        }
    }
}
