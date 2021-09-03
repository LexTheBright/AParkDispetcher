﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AParkDispetcher
{
    class Disp_user
    {
        public struct C1 {
            public string tab_number;
            public string name, surname, midname;
            /*public int state;*/
            /*public string TitleState;*/
            public string login;
            public string password;
            public string role;
        }


        List<C1> usr = new List<C1>();

        public void fillUser()
        {
            usr.Clear();
            string querry = "";
            querry = "USE autos; SELECT user_surname, user_name, user_midname, tab_number, role_title, login FROM users JOIN roles WHERE users.user_role_id = roles.role_id";
            MySqlCommand comm = new MySqlCommand(querry, dbConnection.dbConnect);
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
                        temp_c.role = reader.GetString(4);
                        temp_c.login = reader.GetString(5);
                        /*temp_c.state = reader.GetInt32(6);
                        temp_c.TitleState = StateTitle(temp_c.state);*/
                        //temp_c.role = reader.GetInt32(3);
                        usr.Add(temp_c);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void fillAdminsUserGrid(DataGridView dgw) 
        {
            fillUser();
            for (int i = 0; i < usr.Count; i++)
            {
                dgw.Rows.Add("" + usr[i].surname + " " + usr[i].name + " " + usr[i].midname + "", "" + usr[i].tab_number + "", "" + usr[i].role + "", "" + usr[i].login + "");
                //if (usr[i].state == 0) dgw.CurrentRow.Cells[4].Style.BackColor = System.Drawing.Color.Green;
            }

        }

        public string StateTitle (int state)
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
