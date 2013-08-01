using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form6Akila : Form
    {
        public Form6Akila()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (view.Checked)
            {
                new Form3().Show();
            }

            else if (add.Checked)
            {
                if (sensor.Checked)
                {
                    Form7Akila addSensor = new Form7Akila();
                    addSensor.Show();
                }
                else if (user.Checked)
                {
                    new Form14().Show();
                }
                else if (location.Checked)
                {
                    new Form8().Show();
                }
                else if (service.Checked)
                {
                    new Form10().Show();
                }
                else if (agent.Checked)
                {
                    new Form11().Show();
                }
                
            }
            else if (edit.Checked)
            {
                if (sensor.Checked)
                {
                }
                else if (user.Checked)
                {

                }
                else if (location.Checked)
                {
                }
                else if (service.Checked)
                {

                }
                else if (agent.Checked)
                {
                }
            }
            else if (delete.Checked)
            {
                if (sensor.Checked)
                {
                }
                else if (user.Checked)
                {

                }
                else if (location.Checked)
                {
                }
                else if (service.Checked)
                {

                }
                else if (agent.Checked)
                {
                }
            }
            
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void sensor_CheckedChanged(object sender, EventArgs e)
        {
           
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void user_CheckedChanged(object sender, EventArgs e)
        {
                       
        }

        private void location_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void agent_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            user.Enabled = true;
            location.Enabled = true;
            service.Enabled = true;
            agent.Enabled = true;
            view.Enabled = true;
            sensor.Enabled = true;
            edit.Enabled = true;
            delete.Enabled = true;
            add.Enabled = true;
        }

        private void prev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {

            new Login.exitsys(this).Show();
            //Application.Run(new Login.Login());
            
            //Application.ExitThread();

            
        }

        private void view_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void add_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void edit_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void delete_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form6Akila_Load(object sender, EventArgs e)
        {

        }
    }
}
