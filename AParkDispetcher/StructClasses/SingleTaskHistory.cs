using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AParkDispetcher
{
    class SingleTaskHistory
    {
        public struct TaskHistory
        {
            //1
            public int order_state;
            //
            public DateTime change_time;
            //
            public string changer_tab_number;
            //
            public string chdescription;
            //0
            public DateTime ordered_time;
            //
            public int ordered_duration;
            //
            public string departure, destination;
            //2
            public string ordered_ctype;
            //car_type
            public string car_reg_mark;
            //car_color
            //
            public string user_description;
            //
            public string driver_tab_number;
            //
            public string user_tab_number;
            //
            public string user_surname, user_name, user_midname;
            //
            public string driver_surname, driver_name, driver_midname;
            //
            public string car_type, car_model, car_color;
        }

        public List<TaskHistory> singleTask = new List<TaskHistory>();

        /*public Dictionary<string, int> types = new Dictionary<string, int>();

        public void fillTypes(ComboBox combo)
        {
            types.Clear();
            string querry = "";
            querry = "USE autos; SELECT * FROM ctypes";
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
        }*/

        public void FillHistoryTaskForm(DataGridView dgw, string sld_task_num)
        {
            FillTaskHistory(sld_task_num);
            for (int i = 0; i < singleTask.Count; i++)
            {
                dgw.Rows.Add("" + singleTask[i].order_state + "", "" + singleTask[i].change_time.ToString("dd/MM/yy HH:mm") + "", "" + singleTask[i].changer_tab_number + "", "" + singleTask[i].chdescription + "",
                    "" + singleTask[i].ordered_time.ToString("dd/MM/yy HH:mm") + "", "" + singleTask[i].ordered_duration + "", "" + singleTask[i].departure + "", "" + singleTask[i].destination + "",
                    "" + singleTask[i].ordered_ctype + "", "" + singleTask[i].user_description + "", "" + singleTask[i].car_type + "", "" + singleTask[i].car_reg_mark + "",
                    "" + singleTask[i].car_model + "", "" + singleTask[i].car_color + "", "" + singleTask[i].driver_tab_number + "",
                    "" + singleTask[i].user_surname + " " + "" + singleTask[i].user_name + " " + singleTask[i].user_midname + "");
                //if (usr[i].state == 0) dgw.CurrentRow.Cells[4].Style.BackColor =  System.Drawing.Color.Green;
            }
        }

        public void FillTaskHistory(string sld_task_num)
        {
            singleTask.Clear();
            string querry = "";
            querry = "USE autos; SELECT order_state, ordered_ctype, ordered_time, ordered_duration, departure, destination, " +
                "user_description, car_reg_mark, changer_tab_number, driver_tab_number, chdatetime, chdescription, " +
                "model, color, type, driver_surname, driver_name, driver_midname " +
                "FROM thistory " +
                "LEFT JOIN cars ON thistory.car_reg_mark = cars.reg_mark " +
                "LEFT JOIN drivers ON thistory.driver_tab_number = drivers.tab_number " +
                "LEFT JOIN ctypes ON cars.car_type_id = ctypes.type_id " +
                $"WHERE thistory.task_num = {sld_task_num}";
            MySqlCommand comm = new MySqlCommand(querry, DbConnection.dbConnect);
            try
            {
                using (MySqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TaskHistory temp_task = new TaskHistory();

                        temp_task.order_state = reader.GetInt32(0);

                        if (reader.IsDBNull(1)) temp_task.ordered_ctype = "";
                        else temp_task.ordered_ctype = reader.GetString(1);

                        if (reader.IsDBNull(2)) temp_task.ordered_time = DateTime.Today;
                        else temp_task.ordered_time = reader.GetDateTime(2);

                        if (reader.IsDBNull(3)) temp_task.ordered_duration = 0;
                        else temp_task.ordered_duration = reader.GetInt32(3);

                        temp_task.departure = reader.GetString(4);
                        temp_task.destination = reader.GetString(5);

                        if (reader.IsDBNull(6)) temp_task.user_description = "";
                        else temp_task.user_description = reader.GetString(6);

                        //temp_task.car_reg_mark = reader.GetString(7);

                        if (reader.IsDBNull(8)) temp_task.changer_tab_number = "";
                        else temp_task.changer_tab_number = reader.GetString(8);


                        temp_task.change_time = reader.GetDateTime(10);


                        if (reader.IsDBNull(11)) temp_task.chdescription = "";
                        else temp_task.chdescription = reader.GetString(11);

                        if (reader.IsDBNull(9) || reader.IsDBNull(7))
                        {
                            temp_task.driver_tab_number = "";
                            temp_task.car_reg_mark = "";
                        }
                        else
                        {
                            temp_task.driver_tab_number = reader.GetString(9);
                            temp_task.car_reg_mark = reader.GetString(7);

                            temp_task.car_model = reader.GetString(12);
                            temp_task.car_color = reader.GetString(13);
                            temp_task.car_type = reader.GetString(14);

                            temp_task.driver_surname = reader.GetString(15);
                            temp_task.driver_name = reader.GetString(16);
                            temp_task.driver_midname = reader.GetString(17);
                        }

                        singleTask.Add(temp_task);
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
