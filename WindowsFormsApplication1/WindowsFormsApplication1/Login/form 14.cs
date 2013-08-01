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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new Login.exitsys(this).Show();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string MyConnectionString = "Server=localhost;Database=EMS;Uid=root;Pwd='';";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd = connection.CreateCommand();
            MySqlDataReader rdr = null;

            connection.Open();
            
            cmd.CommandText = "SELECT username from users where username=@name";
            cmd.Parameters.AddWithValue("@name", name.Text.ToString());
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                name.Text = "";
                psword.Text = "";
                psword1.Text = "";
                Login.warning ww = new Login.warning("Invalid Username!",this);
                ww.Show();
                
            }
               
            else
            {
                connection.Close();
                connection.Open();
                MySqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandText = "INSERT INTO users(username,hashcode,privilage_level) VALUES(@name1,@code,@level)";
                cmd1.Parameters.AddWithValue("@name1", name.Text.ToString());
                if (psword.Text.ToString() == psword1.Text.ToString())
                {
                    cmd1.Parameters.AddWithValue("@code", psword.Text.ToString());
                   // cmd1.Parameters.AddWithValue("@level", 3);
                    if (privililage.SelectedItem.ToString() == "High")
                    {
                        cmd1.Parameters.AddWithValue("@level", 1);
                    }
                    else if (privililage.SelectedItem.ToString() == "Medium")
                    {
                        cmd1.Parameters.AddWithValue("@level", 2);
                    }
                    else 
                    {
                        cmd1.Parameters.AddWithValue("@level", 3);
                    }
                   cmd1.ExecuteNonQuery();
                   
                    connection.Close();
                    
                    name.Text = "";
                    psword.Text = "";
                    psword1.Text = "";
                    Login.warning ww = new Login.warning("User Successfully Added!", this);
                    ww.Show();
                    
                }
                else
                {
                    psword.Text = "";
                    psword1.Text = "";
                    Login.warning ww2 = new Login.warning("Password Do Not Match!",this);
                    ww2.Show();

                    
                }

            }


            
            
            
        }
    }
}
