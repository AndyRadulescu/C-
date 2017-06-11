using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Database_Vehicle
{
    public partial class Form1 : Form
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        static string connName = "server=localhost;uid=root;pwd=;database=vehicle;";
        static MySqlConnection conn = new MySqlConnection(connName);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //            string connName = "server=localhost;uid=root;pwd=;database=vehicle;";
            //            MySqlConnection conn = new MySqlConnection(connName);
            //            MySqlCommand cmd = conn.CreateCommand();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * From Vehicle";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                vehicles.Add(new Vehicle((int) reader["id"], reader["type"].ToString(), reader["brand"].ToString(),
                    reader["tehnicaldata"].ToString(), reader["othercharacteristics"].ToString(),
                    reader["platenumber"].ToString(), reader["dateofregistration"].ToString(),
                    reader["owner"].ToString(), reader["lastcheckout"].ToString()));
                // Console.WriteLine(reader["type"].ToString() + " " + reader["brand"].ToString() + " " +
                //           reader["tehnicaldata"]);
            }
            reader.Close();
        }

        //actualizare
        private void refreshButton_Click(object sender, EventArgs e)
        {
            listView.Clear();
            foreach (Vehicle vehicle in vehicles)
            {
                listView.Items.Add(vehicle.ToString());
            }
        }

        //inmatriculare
        private void button1_Click(object sender, EventArgs e)
        {
            string str = listView.SelectedItems[0].Text;
            int id = int.Parse(str.Substring(0, str.IndexOf(",")));
            Vehicle veh = null;
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE vehicle SET dateofregistration = @inmatriculare where id='" + id + "'";
            cmd.Parameters.AddWithValue("@inmatriculare", "acum");
            cmd.ExecuteNonQuery();
            listView.SelectedItems[0].Remove();

            cmd.CommandText = "Select * From Vehicle where id='" + id + "'";

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                veh = new Vehicle((int) reader["id"], reader["type"].ToString(), reader["brand"].ToString(),
                    reader["tehnicaldata"].ToString(), reader["othercharacteristics"].ToString(),
                    reader["platenumber"].ToString(), reader["dateofregistration"].ToString(),
                    reader["owner"].ToString(), reader["lastcheckout"].ToString());
                // Console.WriteLine(reader["type"].ToString() + " " + reader["brand"].ToString() + " " +
                //           reader["tehnicaldata"]);
            }
            listView.Items.Add(veh.ToString());
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView.SelectedItems[0].Remove();
        }

        //schimbare caracteristics
        private void button3_Click(object sender, EventArgs e)
        {
            string str = listView.SelectedItems[0].Text;
            int id = int.Parse(str.Substring(0, str.IndexOf(",")));
            Vehicle veh = null;
            if (details.Text != null || (details.Text.CompareTo("") == 0))
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE vehicle SET othercharacteristics = @details where id='" + id + "'";
                cmd.Parameters.AddWithValue("@details", details.Text);
                cmd.ExecuteNonQuery();
                listView.SelectedItems[0].Remove();

                cmd.CommandText = "Select * From Vehicle where id='" + id + "'";

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    veh = new Vehicle((int) reader["id"], reader["type"].ToString(), reader["brand"].ToString(),
                        reader["tehnicaldata"].ToString(), reader["othercharacteristics"].ToString(),
                        reader["platenumber"].ToString(), reader["dateofregistration"].ToString(),
                        reader["owner"].ToString(), reader["lastcheckout"].ToString());
                    // Console.WriteLine(reader["type"].ToString() + " " + reader["brand"].ToString() + " " +
                    //           reader["tehnicaldata"]);
                }
                listView.Items.Add(veh.ToString());
                reader.Close();
            }
        }

        private void plateNumber_TextChanged(object sender, EventArgs e)
        {
        }

        //cautare dupa plate number
        private void button4_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            listView.Clear();
            if (plateNumber.Text != null || (plateNumber.Text.CompareTo("") == 0))
            {
                cmd.CommandText = "Select * From Vehicle where platenumber='" + plateNumber.Text + "'";
                MySqlDataReader reader = cmd.ExecuteReader();
                Vehicle veh = new Vehicle();
                while (reader.Read())
                {
                    veh = new Vehicle((int) reader["id"], reader["type"].ToString(), reader["brand"].ToString(),
                        reader["tehnicaldata"].ToString(), reader["othercharacteristics"].ToString(),
                        reader["platenumber"].ToString(), reader["dateofregistration"].ToString(),
                        reader["owner"].ToString(), reader["lastcheckout"].ToString());
                    // Console.WriteLine(reader["type"].ToString() + " " + reader["brand"].ToString() + " " +
                    //           reader["tehnicaldata"]);
                }
                if (veh.Id != 0)
                {
                    listView.Items.Add(veh.ToString());
                }
                reader.Close();
            }
        }

        //cautare dupa numele proprietarului
        private void button5_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            listView.Clear();
            if (ownerName.Text != null || (ownerName.Text.CompareTo("") == 0))
            {
                cmd.CommandText = "Select * From Vehicle where owner='" + ownerName.Text + "'";
                MySqlDataReader reader = cmd.ExecuteReader();
                List<Vehicle> list = new List<Vehicle>();
                while (reader.Read())
                {
                    list.Add(new Vehicle((int) reader["id"], reader["type"].ToString(), reader["brand"].ToString(),
                        reader["tehnicaldata"].ToString(), reader["othercharacteristics"].ToString(),
                        reader["platenumber"].ToString(), reader["dateofregistration"].ToString(),
                        reader["owner"].ToString(), reader["lastcheckout"].ToString()));
                    // Console.WriteLine(reader["type"].ToString() + " " + reader["brand"].ToString() + " " +
                    //           reader["tehnicaldata"]);
                }
                if (list.Count > 0)
                {
                    foreach (Vehicle vehicle in list)
                    {
                        listView.Items.Add(vehicle.ToString());
                    }
                }
                else
                {
                    listView.Items.Add("No vehicle with that owner.");
                }
                reader.Close();
            }
        }

        //revizie
        private void button6_Click(object sender, EventArgs e)
        {
            string str = listView.SelectedItems[0].Text;
            int id = int.Parse(str.Substring(0, str.IndexOf(",")));
            Vehicle veh = null;
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE vehicle SET lastcheckout = @lastcheckout where id='" + id + "'";
            cmd.Parameters.AddWithValue("@lastcheckout", "01/23/07");
            cmd.ExecuteNonQuery();
            listView.SelectedItems[0].Remove();

            cmd.CommandText = "Select * From Vehicle where id='" + id + "'";

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                veh = new Vehicle((int) reader["id"], reader["type"].ToString(), reader["brand"].ToString(),
                    reader["tehnicaldata"].ToString(), reader["othercharacteristics"].ToString(),
                    reader["platenumber"].ToString(), reader["dateofregistration"].ToString(),
                    reader["owner"].ToString(), reader["lastcheckout"].ToString());
                // Console.WriteLine(reader["type"].ToString() + " " + reader["brand"].ToString() + " " +
                //           reader["tehnicaldata"]);
            }
            listView.Items.Add(veh.ToString());
            reader.Close();
        }

        //delete
        private void button7_Click(object sender, EventArgs e)
        {
            string str = listView.SelectedItems[0].Text;
            int id = int.Parse(str.Substring(0, str.IndexOf(",")));
            Vehicle veh = null;
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM vehicle WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            listView.SelectedItems[0].Remove();
        }

        //sortare dupa tip
        private void button8_Click(object sender, EventArgs e)
        {
            if (vehicles.Count > 0)
            {
                listView.Clear();
                vehicles.Sort();
                foreach (Vehicle vehicle in vehicles)
                {
                    listView.Items.Add(vehicle.ToString());
                }
            }
        }

        //alocarea unui nr de inmatriculare
        private void button9_Click(object sender, EventArgs e)
        {
            listView.Clear();
            bool ok = false;
            if (plateNumber.Text != null || (plateNumber.Text.CompareTo("") == 0))
            {
                foreach (Vehicle vehicle in vehicles)
                {
                    if (vehicle.PlateNumber.CompareTo(plateNumber.Text) == 0)
                    {
                        ok = true;
                        break;
                    }
                }
                if (ok)
                {
                    listView.Items.Add("Plate number already exists.");
                }
                else
                {
                    listView.Items.Add("Plate number can be alocated , it isn't in the data base.");
                }
            }
        }
    }
}