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
    public partial class Dtable : Form
    {
        //string MyConnectionString = "Server=localhost;Database=EMS;Uid=root;Pwd='';";
        public Dtable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            
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
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emsDataSet.users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.emsDataSet.users);

            
            string MyConnectionString = "Server=localhost;Database=EMS;Uid=root;Pwd='';";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlDataReader rdr = null;
               
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
               
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select location_id,temperature,humidity,rainfall,co2 from current_data";
                cmd.Connection = connection;
                rdr = cmd.ExecuteReader();
                int i=0;
                allData.RowCount = 3;
                while (rdr.Read())
                {
                    if (i < 4)
                    {
                        allData.Rows[i].Cells[0].Value = rdr.GetValue(0).ToString();
                        allData.Rows[i].Cells[1].Value = rdr.GetFloat(1).ToString();
                        allData.Rows[i].Cells[2].Value = rdr.GetFloat(2).ToString();
                        allData.Rows[i].Cells[3].Value = rdr.GetFloat(3).ToString();
                        allData.Rows[i].Cells[4].Value = rdr.GetFloat(4).ToString();

                        i++;
                    }
                }
                allData.Show();
            }
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
