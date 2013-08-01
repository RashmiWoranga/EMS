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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        

        

        
        

        private void prev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            String MyConnectionString = "Server=localhost;Database=EMS;Uid=root;Pwd='';";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO agent(service_provider,agent_id,agent_name,telephone) VALUES(@service_provider,@agent_id,@agent_name,@telephone)";
            cmd.Parameters.AddWithValue("@id", id.Text);

            cmd.Parameters.AddWithValue("@service_provider", service.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@agent_id", id.Text.ToString());
            cmd.Parameters.AddWithValue("@agent_name", name.Text.ToString());
            cmd.Parameters.AddWithValue("@telephone", tp.Text.ToString());
   

            cmd.ExecuteNonQuery();
            connection.Close();

            id.Text = "";
            name.Text = "";
            tp.Text = "";
            
            Login.warning ww = new Login.warning("Agent Successfully Added!", this);
            ww.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            string MyConnectionString = "Server=localhost;Database=EMS;Uid=root;Pwd='';";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlDataReader rdr = null;
            
            connection.Open();
            
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select service_provider from serviceprovider";
            if (connection.State == ConnectionState.Open)
            {                
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    service.Items.Add(rdr.GetValue(0).ToString());
                 }
                connection.Close();
             }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new Login.exitsys(this).Show();
        }

        private void service_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
