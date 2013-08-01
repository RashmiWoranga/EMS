using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form7Akila : Form
    {
        public Form7Akila()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MyConnectionString = "Server=localhost;Database=EMS;Uid=root;Pwd='';";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            MySqlCommand cmd2 = connection.CreateCommand();
            MySqlCommand cmd3 = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO sensor(sensor_id,sensor_type,contract_id,refresh_time,sensor_status) VALUES(@sensor,@type,@cont,@time,@status)";
            cmd.Parameters.AddWithValue("@sensor", id.Text);
            cmd.Parameters.AddWithValue("@type", type.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@cont",contract.Text.ToString());
            DateTime time = Convert.ToDateTime(refreshtime.Text); 
            cmd.Parameters.AddWithValue("@time", time);
            if (contract.Text != null)
            {
                cmd.Parameters.AddWithValue("@status", true);
            }else{
                cmd.Parameters.AddWithValue("@status", true);
            }
            cmd.ExecuteNonQuery();
            connection.Close();
            if (contract.Text != null)
            {

                cmd2.CommandText = "INSERT INTO contract(contract_id,sensor_id,established_date,expire_date,agent_id,Service_provider) VALUES(@contract_id,@sensor_id,@established_date,@expire_date,@agent_id,@Service_provider)";
                cmd2.Parameters.AddWithValue("@contract_id", contract.Text.ToString());
                cmd2.Parameters.AddWithValue("@sensor_id", id.Text.ToString());
                string date1 = establised.Text;
                string date2 = establised.Text;

                DateTime dt1 = Convert.ToDateTime(date1);
                DateTime dt2 = Convert.ToDateTime(date2);

                cmd2.Parameters.AddWithValue("@established_date", dt1.ToString());
                cmd2.Parameters.AddWithValue("@expire_date", dt2.ToString());
                cmd2.Parameters.AddWithValue("@agent_id", agent.SelectedItem.ToString());
                cmd2.Parameters.AddWithValue("@Service_provider", service.SelectedItem.ToString());
                connection.Open();
                cmd2.ExecuteNonQuery();
                connection.Close();

            } 

            
            
            Login.warning ww = new Login.warning("Sensor Successfully Added!", this);
            ww.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Login.exitsys(this).Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
       

        private void Form7Akila_Load(object sender, EventArgs e)
        {
            string MyConnectionString = "Server=localhost;Database=EMS;Uid=root;Pwd='';";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlDataReader rdr = null;
            MySqlDataReader rdr2 = null;
            MySqlDataReader rdr3 = null;
           //+ this.establised.Text = "Not Yet";
            connection.Open();
           // establised.Text = "Now OPen";
            MySqlCommand cmd = connection.CreateCommand();
            MySqlCommand cmd2 = connection.CreateCommand();
            MySqlCommand cmd3 = connection.CreateCommand();
            cmd.CommandText = "select location_id from location";
            if (connection.State == ConnectionState.Open)
            {
              //  establised.Text = "Now in";
                rdr = cmd.ExecuteReader();
               // int i = 1;
                while (rdr.Read())
                {
                    location.Items.Add(rdr.GetValue(0).ToString());
                 }
                connection.Close();
                connection.Open();
                cmd2.CommandText = "select distinct agent_id from agent";
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    agent.Items.Add(rdr2.GetValue(0).ToString());
                }
                connection.Close();
                connection.Open();
                cmd3.CommandText = "select service_provider from serviceprovider";
                rdr3 = cmd3.ExecuteReader();
                while (rdr3.Read())
                {
                    service.Items.Add(rdr3.GetValue(0).ToString());
                }
             }
        }

        private void establised_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
