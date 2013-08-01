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
    public partial class Form1 : Form
    {
        string MyConnectionString = "Server=localhost;Database=EMS;Uid=root;Pwd='';";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            connection.Open();
            if (connection.State==ConnectionState.Open)
            {
               
            }
            MySqlCommand cmd = connection.CreateCommand();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
