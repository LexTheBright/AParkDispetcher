using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AParkDispetcher
{
    class Cars_list
    {
        public struct C1
        {
            public string reg_mark;
            public string model;
            public string color;
            public string description;
            public int state;
            public string type;
            //public int car_type_id;
        }


        public List<C1> usr = new List<C1>();

        public Dictionary<string, int> types = new Dictionary<string, int>();

        public void fillTypes (ComboBox combo)
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

        public void fillCar(DateTime? leftT = null, DateTime? rightT = null)
        {
            usr.Clear();
            string querry = "";
            querry = "USE autos; SELECT reg_mark, model, color, description, car_state, type FROM cars JOIN ctypes WHERE cars.car_type_id = ctypes.type_id ORDER BY car_state ";
            if (leftT != null && rightT != null)
            {
                DateTime ParsedLeft = DateTime.Parse(leftT.ToString());
                DateTime ParsedRight = DateTime.Parse(rightT.ToString());
                querry = $"USE autos; CALL get_free_cars('{ParsedLeft.ToString("yyyy-MM-dd HH:mm:ss")}', '{ParsedRight.ToString("yyyy-MM-dd HH:mm:ss")}')";
            }
            MySqlCommand comm = new MySqlCommand(querry, dbConnection.dbConnect);
            try
            {
                using (MySqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        C1 temp_c = new C1();
                        temp_c.reg_mark = reader.GetString(0);
                        temp_c.model = reader.GetString(1);
                        temp_c.color = reader.GetString(2);

                        if (reader.IsDBNull(3)) temp_c.description = "";
                        else temp_c.description = reader.GetString(3);

                        temp_c.state = reader.GetInt32(4);
                        temp_c.type = reader.GetString(5);
                        usr.Add(temp_c);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void fillSelectCarForm(DataGridView dgw, DateTime? Tleft = null, DateTime? Tright = null)
        {
            if (Tleft != null && Tright != null) fillCar(Tleft, Tright);
            else fillCar();
            for (int i = 0; i < usr.Count; i++)
            {
                dgw.Rows.Add("" + usr[i].reg_mark + "", "" + usr[i].model + "", "" + usr[i].type + "", "" + usr[i].color + "", "" + StateTitle(usr[i].state) + "", "" + usr[i].description + "");
            }
        }

        public void fillAdminsCarGrid(DataGridView dgw)
        {
            fillCar();
            for (int i = 0; i < usr.Count; i++)
            {
                dgw.Rows.Add("" + usr[i].reg_mark + "", "" + usr[i].model + "", "" + usr[i].type + "", "" + usr[i].color + "", "" + StateTitle(usr[i].state) + "");
            }
        }
        public void fillDispatchersCarGrid(DataGridView dgw)
        {
            fillCar();
            for (int i = 0; i < usr.Count; i++)
            {
                dgw.Rows.Add("" + usr[i].model + "", "" + usr[i].reg_mark + "", "" + usr[i].state + "", "" + usr[i].description + "");
            }
        }

        public string StateTitle(int state)
        {
            switch (state)
            {
                case 0:
                    return "Доступна";
                case 1:
                    return "Не доступна";
                default:
                    return "Неизвестное состояние";
            }
        }
    }
}
