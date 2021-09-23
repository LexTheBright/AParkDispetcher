using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AParkDispetcher
{
    class Disp_tasks
    {
        public struct Task
        {
            // порядковый номер заявки
            public string task_number;
            // 
            public DateTime orderdatetime;
            //
            public int order_state;
            //
            public string ordered_ctype;
            //
            public DateTime ordered_time;
            //
            public int ordered_duration;
            //
            public string departure, destination;
            //
            public string user_description, chdescription;
            //
            public string driver_tab_number;
            //
            public string car_reg_mark;
            //
            public string user_tab_number;


            //
            public string user_surname, user_name, user_midname;
            //
            public string driver_surname, driver_name, driver_midname;
            //
            public string car_model, car_color, car_type;
        }

        public List<Task> usr = new List<Task>();

        public Dictionary<string, int> types = new Dictionary<string, int>();

        public void fillComboboxWithTypes(ComboBox combo)
        {
            types.Clear();
            string querry = "";
            querry = "USE autos; SELECT * FROM ctypes ORDER BY type_id";
            MySqlCommand comm = new MySqlCommand(querry, dbConnection.dbConnect);
            try
            {
                using (MySqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int temp_id;
                        string temp_type;

                        temp_id = reader.GetInt32(0);
                        temp_type = reader.GetString(1);

                        types.Add(temp_type, temp_id);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            foreach (var type in types.Keys)
            {
                combo.Items.Add(type);
            }
        }

        public void fillDispetcherTasks(DataGridView dgw)
        {
            fillTasks();
            for (int i = 0; i < usr.Count; i++)
            {
                dgw.Rows.Add( "" + usr[i].task_number + "", "" + usr[i].orderdatetime.ToString("dd.MM  [HH:mm]") + "", "" + usr[i].user_tab_number + "", "" + usr[i].order_state + "", 
                    "" + usr[i].ordered_time + "", "" + usr[i].ordered_duration + "", "" + usr[i].departure + "", "" + usr[i].destination + "",
                    "" + usr[i].user_description + "", "" + usr[i].chdescription + "", "" + usr[i].driver_tab_number + "", "" + usr[i].car_reg_mark + "",
                    "" + usr[i].car_type + "", "" + usr[i].car_color + "", "" + usr[i].ordered_ctype + "", 
                    "" + usr[i].user_surname + " " + "" + usr[i].user_name + " " + usr[i].user_midname + "", "" + usr[i].car_model + "");
                //if (usr[i].state == 0) dgw.CurrentRow.Cells[4].Style.BackColor =  System.Drawing.Color.Green;
            }
        }

        public void fillTasks()
        {
            usr.Clear();
            string querry = "";
            querry = "USE autos; SELECT task_num, orderdatetime,  order_state, ordered_ctype, ordered_time, ordered_duration, departure, destination, " +
                "user_description, chdescription, driver_tab_number, car_reg_mark, user_tab_number, " +
                "model, color, type, user_surname, user_name, user_midname, driver_surname, driver_name, driver_midname " +
                "FROM tasks " +
                "LEFT JOIN cars ON tasks.car_reg_mark = cars.reg_mark " +
                "LEFT JOIN drivers ON tasks.driver_tab_number = drivers.tab_number " +
                "LEFT JOIN ctypes ON cars.car_type_id = ctypes.type_id " +
                "JOIN users ON tasks.user_tab_number = users.tab_number ";
            MySqlCommand comm = new MySqlCommand(querry, dbConnection.dbConnect);
            try
            {
                using (MySqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Task temp_task = new Task();
                        temp_task.task_number = reader.GetString(0);

                        if (reader.IsDBNull(1)) temp_task.orderdatetime = DateTime.Today;
                        else temp_task.orderdatetime = reader.GetDateTime(1);

                        temp_task.order_state = reader.GetInt32(2);

                        if (reader.IsDBNull(3)) temp_task.ordered_ctype = "";
                        else temp_task.ordered_ctype = reader.GetString(3);

                        if (reader.IsDBNull(4)) temp_task.ordered_time = DateTime.Today;
                        temp_task.ordered_time = reader.GetDateTime(4);

                        if (reader.IsDBNull(5)) temp_task.ordered_duration = 0;
                        else temp_task.ordered_duration = reader.GetInt32(5);

                        temp_task.departure = reader.GetString(6);
                        temp_task.destination = reader.GetString(7);

                        if (reader.IsDBNull(8)) temp_task.user_description = "";
                        else temp_task.user_description = reader.GetString(8);

                        if (reader.IsDBNull(9)) temp_task.chdescription = "";
                        else temp_task.chdescription = reader.GetString(9);


                        temp_task.user_tab_number = reader.GetString(12);
                        temp_task.user_surname = reader.GetString(16);
                        temp_task.user_name = reader.GetString(17);
                        temp_task.user_midname = reader.GetString(18);


                        if (reader.IsDBNull(10) || reader.IsDBNull(11)) {
                            temp_task.driver_tab_number = "";
                            temp_task.car_reg_mark = "";
                        }
                        else
                        {
                            temp_task.driver_tab_number = reader.GetString(10);
                            temp_task.car_reg_mark = reader.GetString(11);

                            temp_task.car_model = reader.GetString(13);
                            temp_task.car_color = reader.GetString(14);
                            temp_task.car_type = reader.GetString(15);

                            temp_task.driver_surname = reader.GetString(19);
                            temp_task.driver_name = reader.GetString(20);
                            temp_task.driver_midname = reader.GetString(21);
                        }

                        usr.Add(temp_task);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
