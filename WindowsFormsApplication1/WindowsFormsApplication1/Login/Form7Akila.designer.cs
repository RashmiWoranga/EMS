namespace WindowsFormsApplication1
{
    partial class Form7Akila
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7Akila));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.refreshtime = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.service = new System.Windows.Forms.ComboBox();
            this.agent = new System.Windows.Forms.ComboBox();
            this.location = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.establised = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.expired = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contract = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(317, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add Sensor Details";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SeaGreen;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(110, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Agent ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SeaGreen;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(110, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Service Provider ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SeaGreen;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(110, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Location ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SeaGreen;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(110, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Refresh Time";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.SeaGreen;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(110, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Contract ID";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.SeaGreen;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(110, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Sensor Type";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.SeaGreen;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(110, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Sensor ID";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.SeaShell;
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.Black;
            this.id.Location = new System.Drawing.Point(312, 95);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(285, 16);
            this.id.TabIndex = 16;
            this.id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // refreshtime
            // 
            this.refreshtime.BackColor = System.Drawing.Color.SeaShell;
            this.refreshtime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.refreshtime.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshtime.ForeColor = System.Drawing.Color.Black;
            this.refreshtime.Location = new System.Drawing.Point(312, 189);
            this.refreshtime.Name = "refreshtime";
            this.refreshtime.Size = new System.Drawing.Size(285, 16);
            this.refreshtime.TabIndex = 20;
            this.refreshtime.Text = "HH:MM:SS";
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.SeaGreen;
            this.type.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Humidity",
            "Rain Fall",
            "Wind",
            "Temperature",
            "CO2"});
            this.type.Location = new System.Drawing.Point(312, 121);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(285, 24);
            this.type.TabIndex = 24;
            // 
            // service
            // 
            this.service.BackColor = System.Drawing.Color.SeaGreen;
            this.service.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.service.FormattingEnabled = true;
            this.service.Location = new System.Drawing.Point(312, 259);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(285, 24);
            this.service.TabIndex = 25;
            // 
            // agent
            // 
            this.agent.BackColor = System.Drawing.Color.SeaGreen;
            this.agent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agent.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.agent.FormattingEnabled = true;
            this.agent.Location = new System.Drawing.Point(312, 294);
            this.agent.Name = "agent";
            this.agent.Size = new System.Drawing.Size(285, 24);
            this.agent.TabIndex = 26;
            // 
            // location
            // 
            this.location.BackColor = System.Drawing.Color.SeaGreen;
            this.location.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.location.FormattingEnabled = true;
            this.location.Location = new System.Drawing.Point(312, 222);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(285, 24);
            this.location.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.SeaGreen;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(110, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Established On";
            // 
            // establised
            // 
            this.establised.BackColor = System.Drawing.Color.SeaShell;
            this.establised.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.establised.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.establised.ForeColor = System.Drawing.Color.Black;
            this.establised.Location = new System.Drawing.Point(312, 338);
            this.establised.Name = "establised";
            this.establised.Size = new System.Drawing.Size(285, 16);
            this.establised.TabIndex = 34;
            this.establised.Text = "DD/MM/YYYY";
            this.establised.TextChanged += new System.EventHandler(this.establised_TextChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::WindowsFormsApplication1.Properties.Resources.tango_go_top_115953;
            this.button3.Location = new System.Drawing.Point(757, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 32;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources._1363526619_ark2;
            this.button1.Location = new System.Drawing.Point(420, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 31;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::WindowsFormsApplication1.Properties.Resources.tango_go_previous_115999;
            this.button2.Location = new System.Drawing.Point(43, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Image = global::WindowsFormsApplication1.Properties.Resources.sss;
            this.label1.Location = new System.Drawing.Point(0, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(855, 497);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // expired
            // 
            this.expired.BackColor = System.Drawing.Color.SeaShell;
            this.expired.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expired.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expired.ForeColor = System.Drawing.Color.Black;
            this.expired.Location = new System.Drawing.Point(312, 369);
            this.expired.Name = "expired";
            this.expired.Size = new System.Drawing.Size(285, 16);
            this.expired.TabIndex = 35;
            this.expired.Text = "DD/MM/YYYY";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SeaGreen;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(110, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Established On";
            // 
            // contract
            // 
            this.contract.BackColor = System.Drawing.Color.SeaShell;
            this.contract.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contract.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract.ForeColor = System.Drawing.Color.Black;
            this.contract.Location = new System.Drawing.Point(312, 154);
            this.contract.Name = "contract";
            this.contract.Size = new System.Drawing.Size(285, 16);
            this.contract.TabIndex = 37;
            // 
            // Form7Akila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 481);
            this.Controls.Add(this.contract);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.expired);
            this.Controls.Add(this.establised);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.location);
            this.Controls.Add(this.agent);
            this.Controls.Add(this.service);
            this.Controls.Add(this.type);
            this.Controls.Add(this.refreshtime);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7Akila";
            this.Text = "EMS - Add Sensor";
            this.Load += new System.EventHandler(this.Form7Akila_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox refreshtime;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.ComboBox service;
        private System.Windows.Forms.ComboBox agent;
        private System.Windows.Forms.ComboBox location;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox establised;
        private System.Windows.Forms.TextBox expired;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contract;
    }
}