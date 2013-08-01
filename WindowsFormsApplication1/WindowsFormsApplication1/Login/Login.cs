using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using WindowsFormsApplication1.Login;


namespace WindowsFormsApplication1.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void GO_Click(object sender, EventArgs e)
        {
           // new Dtable().Show();
           // new Form6Akila().Show();
            String username, psword;
            username = name.Text;
            psword = pwd.Text;
            string MyConnectionString = "Server=localhost;Database=EMS;Uid=root;Pwd='';";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlDataReader rdr = null;
            MySqlCommand cmd = connection.CreateCommand();
            connection.Open();
             // textBox1.Text = "Done";
                
                //cmd.CommandText = "select hashcode,privilage_level from users where username='" +name.Text.Trim().ToString() + "'";
                cmd.CommandText = "select username,privilage_level from users where username=@name and hashcode=AES_ENCRYPT(@pwd,@key)";
                //INSERT INTO users VALUES ("rash",AES_ENCRYPT('modaya','password'),3);
                cmd.Parameters.AddWithValue("@name", username);
                cmd.Parameters.AddWithValue("@pwd", psword);
                cmd.Parameters.AddWithValue("@key", "password");
               // cmd.Connection = connection;
                rdr = cmd.ExecuteReader();
                Boolean did=false;
                
                while (rdr.Read())
                {
                    if (rdr.GetValue(0).ToString() == username)
                    {
                        int y = int.Parse(rdr.GetValue(1).ToString()) ;
                        if (y== 1)
                        {
                            did = true;
                            new Form6Akila().Show();
                           // break;
                            

                        }
                        else if (y == 2)
                        {
                            did = true;
                          //  connection.Close();
                            new Form3().Show();
                          //  break;
                          //  this.Close();

                        }
                        else if (y == 3)
                        {
                            did = true;
                        }
                        else
                        {
                            //new warning("Log In Error - Try Again!", this).Show();
                        }

                    }

                  
                    
                    }
                if (did)
                {
                    connection.Close();
                    this.Visible = false;
                    //this.Close();
                }
                else
                {
                      name.Text = "";
                     pwd.Text = "";
                    new warning("Log In Error - Try Again!", this).Show();
                }
               
                
                

            }
            

        

       

    }
}
//