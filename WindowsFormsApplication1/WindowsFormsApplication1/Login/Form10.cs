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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string MyConnectionString = "Server=localhost;Database=EMS;Uid=root;Pwd='';";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO serviceprovider(service_provider,postbox,street,city,country) VALUES(@service_provider,@postbox,@street,@city,@country)";
            cmd.Parameters.AddWithValue("@service_provider", id.Text);
            cmd.Parameters.AddWithValue("@postbox", pobox.Text.ToString());
            cmd.Parameters.AddWithValue("@street", street.Text.ToString());
            cmd.Parameters.AddWithValue("@city", city.Text.ToString());
            cmd.Parameters.AddWithValue("@country", country.Text.ToString());
            

            cmd.ExecuteNonQuery();
            
            
            id.Text = "";
            pobox.Text = "";
            street.Text = "";
            city.Text = "";
            country.Text = "";
            email.Text = "";
            connection.Close();
            Login.warning ww = new Login.warning("'Service Provider Successfully Added!", this);
            ww.Show();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Login.exitsys(this).Show();
        }
    }
}
