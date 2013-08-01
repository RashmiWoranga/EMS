using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;


namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void all_CheckedChanged(object sender, EventArgs e)
        {
            if (all.Checked)
            {
                tab1.Enabled = false;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string MyConnectionString = "Server=localhost;Database=EMS;Uid=root;Pwd='';";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlDataReader rdr = null;

            tmp1.Visible = false;
            co1.Visible = false;
            hum1.Visible = false;
            rain1.Visible = false;
            temperature.Visible = false;
            co2.Visible = false;
            humidity.Visible = false;
            rainfall.Visible = false;
            sensorid.Enabled = false;
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select location_id from location";
            if (connection.State == ConnectionState.Open)
            {
                rdr = cmd.ExecuteReader();
                String xx;
                while (rdr.Read())
                {
                    xx = rdr.GetValue(0).ToString();
                    location1.Items.Add(xx);
                    locationid2.Items.Add(xx);
                    location3.Items.Add(xx);
                   
                }
                connection.Close();
            }
        }

        private void temp1_CheckedChanged(object sender, EventArgs e)
        {
            if (all.Checked)
            {
                             
                co21.Enabled = false;
                humidity1.Enabled = false;
                rainfall1.Enabled = false;
            }
        }

        private void wind1_CheckedChanged(object sender, EventArgs e)
        {
            if (all.Checked)
            {
                temp1.Enabled = false;
                co21.Enabled = false;
                humidity1.Enabled = false;
                rainfall1.Enabled = false;
            }
        }

        private void co21_CheckedChanged(object sender, EventArgs e)
        {
            if (all.Checked)
            {
                
                temp1.Enabled = false;
                humidity1.Enabled = false;
                rainfall1.Enabled = false;
            }
        }

        private void rainfall1_CheckedChanged(object sender, EventArgs e)
        {
            if (all.Checked)
            {
                
                co21.Enabled = false;
                humidity1.Enabled = false;
                temp1.Enabled = false;
            }
        }

        private void humidity1_CheckedChanged(object sender, EventArgs e)
        {
            if (all.Checked)
            {
               
                co21.Enabled = false;
                temp1.Enabled = false;
                rainfall1.Enabled = false;
            }
        }

        private void select1_CheckedChanged(object sender, EventArgs e)
        {
            if (select1.Checked)
            {
                tab1.Enabled = true;
            }
        }

        private void refresh1_Click(object sender, EventArgs e)
        {
            
            co21.Enabled = true;
            temp1.Enabled = true;
            rainfall1.Enabled = true;
            humidity1.Enabled = true;
           
            co21.Checked = false;
            temp1.Checked = false;
            rainfall1.Checked = false;
            humidity1.Checked = false;
            tmp1.Visible = false;
            co1.Visible = false;
            hum1.Visible = false;
            rain1.Visible = false;
        }

        private void n_Click(object sender, EventArgs e)
        {
            tmp1.Visible = false;
            co1.Visible = false;
            hum1.Visible = false;
            rain1.Visible = false;
            if (all.Checked)
            {
                new Dtable().Show();
            }
            if (select1.Checked)
            {
                string MyConnectionString = "Server=localhost;Database=EMS;Uid=root;Pwd='';";
                MySqlConnection connection = new MySqlConnection(MyConnectionString);
                MySqlDataReader rdr = null;
                

                connection.Open();

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select temperature,humidity,rainfall,co2 from current_data where location_id=@location";
                cmd.Parameters.AddWithValue("@location",location1.SelectedItem.ToString());
                if (connection.State == ConnectionState.Open)
                {
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                       
                        tmp1.Text = rdr.GetValue(0).ToString();
                        hum1.Text = rdr.GetValue(1).ToString();
                        rain1.Text = rdr.GetValue(2).ToString();
                        co1.Text = rdr.GetValue(3).ToString();
                    }
                    connection.Close();
                    if (temp1.Checked)
                    {
                        tmp1.Visible = true;
                        
                    }
                    if (humidity1.Checked)
                    {
                        //wid1.Visible = false;
                        //co1.Visible = false;
                        hum1.Visible = true;
                        //rain1.Visible = false;
                    }
                    if (rainfall1.Checked)
                    {
                        rain1.Visible = true;
                    }
                    if (co21.Checked)
                    {
                        co1.Visible = true;
                    }

                }
            }
        }

        private void prev3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void go3_Click(object sender, EventArgs e)
        {
             string MyConnectionString = "Server=localhost;Database=EMS;Uid=root;Pwd='';";
                MySqlConnection connection = new MySqlConnection(MyConnectionString);
                MySqlDataReader rdr = null;
                temperature.Text = "";
                humidity.Text = "";
                rainfall.Text = "";
                co2.Text = "";
                temperature.Visible = false;
                co2.Visible = false;
                humidity.Visible = false;
                rainfall.Visible = false;

                connection.Open();

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select avg_day_temperature,avg_day_humidity,avg_day_rainfall,avg_day_co2 from current_data where location_id=@location";
                cmd.Parameters.AddWithValue("@location",locationid2.SelectedItem.ToString());
                if (connection.State == ConnectionState.Open)
                {
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {

                        temperature.Text = rdr.GetValue(0).ToString();
                        humidity.Text = rdr.GetValue(1).ToString();
                        rainfall.Text = rdr.GetValue(2).ToString();
                        co2.Text = rdr.GetValue(3).ToString();
                    }
                    connection.Close();

                }
            if (t.Checked)
            {
                temperature.Visible = true;
            }
            if (c.Checked)
            {
                co2.Visible = true;
            }
            if (r.Checked)
            {
                rainfall.Visible = true;
            }
            if (h.Checked)
            {
                humidity.Visible = true;
            }
        }

        private void prev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void location3_SelectedIndexChanged(object sender, EventArgs e)
        {
            sensorid.Enabled = true;
            string MyConnectionString = "Server=localhost;Database=EMS;Uid=root;Pwd='';";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlDataReader rdr = null;

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select sensor_id from contains where location_id=@abc";
            cmd.Parameters.AddWithValue("@abc", location3.SelectedItem.ToString());
            sensorid.Items.Clear();
            if (connection.State == ConnectionState.Open)
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                   sensorid.Items.Add(rdr.GetValue(0).ToString());
                  }
                connection.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string MyConnectionString = "Server=localhost;Database=EMS;Uid=root;Pwd='';";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlDataReader rdr = null;

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select sensor_type from sensor where sensor_id=@abc";
            cmd.Parameters.AddWithValue("@abc", sensorid.SelectedItem.ToString());
            if (connection.State == ConnectionState.Open)
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    type.Text = rdr.GetValue(0).ToString();
                }
                connection.Close();
            }
            connection.Open();
            cmd.CommandText = "select contract_id,established_date,expire_date,agent_id,Service_provider from contract where sensor_id=@bcd";
            cmd.Parameters.AddWithValue("@bcd", sensorid.SelectedItem.ToString());
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //type.Text = rdr.GetValue(0).ToString();
                establised.Text = rdr.GetValue(1).ToString();
                expire.Text = rdr.GetValue(2).ToString();
                contractID.Text = rdr.GetValue(0).ToString();
                agentID.Text = rdr.GetValue(3).ToString();
                service.Text = rdr.GetValue(4).ToString();

            }
            connection.Close();
     
        }

       

        private void cco2_CheckedChanged(object sender, EventArgs e)
        {
            if (cco2.Checked)
            {
                crain.Enabled = false;
                chumi.Enabled = false;
                ctemp.Enabled = false;
                
            }
        }

        private void chumi_CheckedChanged(object sender, EventArgs e)
        {
            if (chumi.Checked)
            {
                crain.Enabled = false;
                cco2.Enabled = false;
                ctemp.Enabled = false;

            }
        }

        private void crain_CheckedChanged(object sender, EventArgs e)
        {
            if (crain.Checked)
            {
                chumi.Enabled = false;
                cco2.Enabled = false;
                ctemp.Enabled = false;

            }
        }

        private void ctemp_CheckedChanged(object sender, EventArgs e)
        {
            if (ctemp.Checked)
            {
                chumi.Enabled = false;
                cco2.Enabled = false;
                crain.Enabled = false;

            }
        }

        private void cweek_CheckedChanged(object sender, EventArgs e)
        {
            if (cweek.Checked)
            {
                cmonth.Enabled = false;
                cyear.Enabled = false;
               
            }
        }

        private void cmonth_CheckedChanged(object sender, EventArgs e)
        {
            if (cmonth.Checked)
            {
                cweek.Enabled = false;
                cyear.Enabled = false;

            }
        }

        private void cyear_CheckedChanged(object sender, EventArgs e)
        {
            if (cyear.Checked)
            {
                cweek.Enabled = false;
                cmonth.Enabled = false;

            }
        }

        private void refresh2_Click(object sender, EventArgs e)
        {

                cco2.Enabled = true;
                crain.Enabled = true;
                chumi.Enabled = true;
                ctemp.Enabled =  true;
                cweek.Enabled = true;
                cmonth.Enabled = true; ;
                cyear.Enabled = true;
                cco2.Checked = false;
                crain.Checked = false;
                chumi.Checked = false;
                ctemp.Checked = false;
                cweek.Checked = false;
                cmonth.Checked = false; ;
                cyear.Checked = false;
                
                
        }

        private void prev2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void go2_Click(object sender, EventArgs e)
        {
            string MyConnectionString = "Server=localhost;Database=EMS;Uid=root;Pwd='';";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlDataReader rdr = null;
           // Boolean done=false;
            connection.Open();
            //float[] data;
            //String[] days;

            MySqlCommand cmd = connection.CreateCommand();
            //cmd.CommandText = "select avg(@abc) from statictics where day > DATE_SUB(CURDATE(),INTERVAL 7 DAY) group by day";
            


            
            if (cweek.Checked)
            {
                float[] abc = new float[7];
                String[] day = new String[7];
                String temp = "1st";
                int i = 0;
                if (cco2.Checked)
                {
                    cmd.CommandText = "select day,avg(avg_co2) from statictics where day > DATE_SUB(CURDATE(),INTERVAL 30 DAY) group by day";
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        if (i < 7)
                        {
                            day[i] = rdr.GetValue(0).ToString();
                            temp = rdr.GetValue(1).ToString();
                            abc[i] = float.Parse(temp);
                            // abc[i] = float.Parse(rdr.GetValue(1).ToString());

                            i++;
                        }

                    }
                    connection.Close();
                }
                if (crain.Checked)
                {
                    cmd.CommandText = "select day,avg(avg_rainfall) from statictics where day > DATE_SUB(CURDATE(),INTERVAL 30 DAY) group by day";
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        if (i < 7)
                        {
                            day[i] = rdr.GetValue(0).ToString();
                            abc[i] = float.Parse(rdr.GetValue(1).ToString());
                            // abc[i] = float.Parse(rdr.GetValue(1).ToString());
                            
                            i++;
                        }

                    }
                    connection.Close();
                }
                if (chumi.Checked)
                {
                    cmd.CommandText = "select day,avg(avg_humidity) from statictics where day > DATE_SUB(CURDATE(),INTERVAL 30 DAY) group by day";
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        if (i < 7)
                        {
                            day[i] = rdr.GetValue(0).ToString();
                            temp = rdr.GetValue(1).ToString();
                            abc[i] = float.Parse(temp);
                            // abc[i] = float.Parse(rdr.GetValue(1).ToString());

                            i++;
                        }

                    }
                    connection.Close();
                }
                if (ctemp.Checked)
                {
                    cmd.CommandText = "select day,avg(avg_temp) from statictics where day > DATE_SUB(CURDATE(),INTERVAL 30 DAY) group by day";
                    rdr = cmd.ExecuteReader();
                    abc[0] = 0.00f;
                    abc[1] = 0.00f;
                    abc[2] = 0.00f;
                    abc[3] = 0.00f;
                    abc[4] = 0.00f;
                    abc[5] = 0.00f;
                    abc[6] = 0.00f;
                   
                    while (rdr.Read())
                    {
                        if (i < 7)
                        {
                            day[i] = rdr.GetValue(0).ToString();
                            
                            abc[i] = abc[i]+float.Parse(rdr.GetValue(1).ToString());
                           
                            i++;
                        }

                    }
                    connection.Close();
                }


                  //   show.Text = abc[6].ToString();
                    new adminsensor(abc,day,"This Week").Show();
                

            }
            if (cmonth.Checked)
            {
                float[] abc = new float[4];
                String[] day = new String[4];
                int i = 0;
                abc[0] = 0.00f;
                abc[1] = 0.00f;
                abc[2] = 0.00f;
                abc[3] = 0.00f;

                if (cco2.Checked)
                {
                    cmd.CommandText = "select day,avg(avg_co2) from statictics where day > DATE_SUB(CURDATE(),INTERVAL 30 DAY) group by day";
                    rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        if (i < 7)
                        {

                            abc[0] += float.Parse(rdr.GetValue(1).ToString());
                            i++;
                        }
                        else if (i < 14)
                        {
                            abc[1] += float.Parse(rdr.GetValue(1).ToString());
                            i++;
                        }
                        else if (i < 21)
                        {
                            abc[2] += float.Parse(rdr.GetValue(1).ToString());
                            i++;
                        }
                        else if (i < 28)
                        {
                            abc[3] += float.Parse(rdr.GetValue(1).ToString());
                            i++;
                        }

                    }
                
                }
                if (crain.Checked)
                {
                    cmd.CommandText = "select day,avg(avg_rainfall) from statictics where day > DATE_SUB(CURDATE(),INTERVAL 7 DAY) group by day";
                    rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        if (i < 7)
                        {

                            abc[0] += float.Parse(rdr.GetValue(1).ToString());
                            i++;
                        }
                        else if (i < 14)
                        {
                            abc[1] += float.Parse(rdr.GetValue(1).ToString());
                            i++;
                        }
                        else if (i < 21)
                        {
                            abc[2] += float.Parse(rdr.GetValue(1).ToString());
                            i++;
                        }
                        else if (i < 28)
                        {
                            abc[3] += float.Parse(rdr.GetValue(1).ToString());
                            i++;
                        }

                    }
                }
                if (chumi.Checked)
                {
                    cmd.CommandText = "select day,avg(avg_humidity) from statictics where day > DATE_SUB(CURDATE(),INTERVAL 7 DAY) group by day";
                    rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        if (i < 7)
                        {

                            abc[0] += float.Parse(rdr.GetValue(1).ToString());
                            i++;
                        }
                        else if (i < 14)
                        {
                            abc[1] += float.Parse(rdr.GetValue(1).ToString());
                            i++;
                        }
                        else if (i < 21)
                        {
                            abc[2] += float.Parse(rdr.GetValue(1).ToString());
                            i++;
                        }
                        else if (i < 28)
                        {
                            abc[3] += float.Parse(rdr.GetValue(1).ToString());
                            i++;
                        }

                    }
                
                }
                if (ctemp.Checked)
                {
                    cmd.CommandText = "select day,avg(avg_temp) from statictics where day > DATE_SUB(CURDATE(),INTERVAL 7 DAY) group by day";
                    rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {
                        if (i < 7)
                        {

                            abc[0] += float.Parse(rdr.GetValue(1).ToString());
                            i++;
                        }
                        else if (i < 14)
                        {
                            abc[1] += float.Parse(rdr.GetValue(1).ToString());
                            i++;
                        }
                        else if (i < 21)
                        {
                            abc[2] += float.Parse(rdr.GetValue(1).ToString());
                            i++;
                        }
                        else if (i < 28)
                        {
                            abc[3] += float.Parse(rdr.GetValue(1).ToString());
                            i++;
                        }

                    }
                
                }
  
                    
                    abc[0] = abc[0] / 7.0f;
                    abc[1] = abc[1] / 7.0f;
                    abc[2] = abc[2] / 7.0f;
                    abc[3] = abc[3] / 7.0f;
                    day[0] = "Week 1";
                    day[1] = "Week 2";
                    day[2] = "Week 3";
                    day[3] = "Week 4";
                    connection.Close();
                   // show.Text = abc[1].ToString();
                    new adminsensor(abc, day, "This Month").Show();
                
            }
            if (cyear.Checked)
            {
                  //cmd.CommandText = "select day,avg(@abc) from statictics where day > DATE_SUB(CURDATE(),INTERVAL 12 MONTH) group by day";
                  //  rdr = cmd.ExecuteReader();
                  //  while (rdr.Read())
                  //  {

                  //  }
                  //  connection.Close();
                
                
            }

            
          


            // chart1.SaveImage(@"c:\myChart.png", chart1.PNG);
           
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Login.exitsys(this).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Login.exitsys(this).Show();
        }

        private void logout3_Click(object sender, EventArgs e)
        {
            new Login.exitsys(this).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Login.exitsys(this).Show();
        }

        private void sensorid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
  

    }
}
