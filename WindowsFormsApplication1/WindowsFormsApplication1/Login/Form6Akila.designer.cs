namespace WindowsFormsApplication1
{
    partial class Form6Akila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6Akila));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sensor = new System.Windows.Forms.RadioButton();
            this.agent = new System.Windows.Forms.RadioButton();
            this.service = new System.Windows.Forms.RadioButton();
            this.location = new System.Windows.Forms.RadioButton();
            this.user = new System.Windows.Forms.RadioButton();
            this.view = new System.Windows.Forms.RadioButton();
            this.refresh = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.RadioButton();
            this.edit = new System.Windows.Forms.RadioButton();
            this.add = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(363, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "AMEND";
            // 
            // sensor
            // 
            this.sensor.AutoSize = true;
            this.sensor.BackColor = System.Drawing.Color.SeaGreen;
            this.sensor.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.sensor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensor.ForeColor = System.Drawing.Color.White;
            this.sensor.Location = new System.Drawing.Point(25, 19);
            this.sensor.Name = "sensor";
            this.sensor.Size = new System.Drawing.Size(79, 20);
            this.sensor.TabIndex = 19;
            this.sensor.Text = "SENSOR";
            this.sensor.UseVisualStyleBackColor = true;
            this.sensor.CheckedChanged += new System.EventHandler(this.sensor_CheckedChanged);
            // 
            // agent
            // 
            this.agent.AutoSize = true;
            this.agent.BackColor = System.Drawing.Color.SeaGreen;
            this.agent.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.agent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agent.ForeColor = System.Drawing.Color.White;
            this.agent.Location = new System.Drawing.Point(25, 176);
            this.agent.Name = "agent";
            this.agent.Size = new System.Drawing.Size(70, 20);
            this.agent.TabIndex = 20;
            this.agent.Text = "AGENT";
            this.agent.UseVisualStyleBackColor = true;
            this.agent.CheckedChanged += new System.EventHandler(this.agent_CheckedChanged);
            // 
            // service
            // 
            this.service.AutoSize = true;
            this.service.BackColor = System.Drawing.Color.SeaGreen;
            this.service.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.service.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service.ForeColor = System.Drawing.Color.White;
            this.service.Location = new System.Drawing.Point(25, 135);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(152, 20);
            this.service.TabIndex = 21;
            this.service.Text = "SERVICE PROVIDER";
            this.service.UseVisualStyleBackColor = true;
            this.service.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.BackColor = System.Drawing.Color.SeaGreen;
            this.location.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.location.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.ForeColor = System.Drawing.Color.White;
            this.location.Location = new System.Drawing.Point(25, 95);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(85, 20);
            this.location.TabIndex = 22;
            this.location.Text = "LOCAION";
            this.location.UseVisualStyleBackColor = true;
            this.location.CheckedChanged += new System.EventHandler(this.location_CheckedChanged);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.SeaGreen;
            this.user.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.user.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(25, 56);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(60, 20);
            this.user.TabIndex = 23;
            this.user.Text = "USER";
            this.user.UseVisualStyleBackColor = true;
            this.user.CheckedChanged += new System.EventHandler(this.user_CheckedChanged);
            // 
            // view
            // 
            this.view.AutoSize = true;
            this.view.BackColor = System.Drawing.Color.SeaGreen;
            this.view.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.view.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.Color.White;
            this.view.Location = new System.Drawing.Point(47, 28);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(102, 20);
            this.view.TabIndex = 24;
            this.view.Text = "VIEW DATA";
            this.view.UseVisualStyleBackColor = true;
            this.view.CheckedChanged += new System.EventHandler(this.view_CheckedChanged);
            // 
            // refresh
            // 
            this.refresh.Image = global::WindowsFormsApplication1.Properties.Resources._11935269_refresh_button_with_arrows_3d_icon_isolated_on_white;
            this.refresh.Location = new System.Drawing.Point(34, 393);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(50, 50);
            this.refresh.TabIndex = 25;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Image = global::WindowsFormsApplication1.Properties.Resources.tango_go_top_115953;
            this.logout.Location = new System.Drawing.Point(762, 393);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(50, 50);
            this.logout.TabIndex = 17;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // go
            // 
            this.go.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.Image = global::WindowsFormsApplication1.Properties.Resources.tango_go_next_115997;
            this.go.Location = new System.Drawing.Point(426, 393);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(50, 50);
            this.go.TabIndex = 16;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.button3_Click);
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.BackColor = System.Drawing.Color.SeaGreen;
            this.delete.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.delete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(47, 174);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(116, 20);
            this.delete.TabIndex = 28;
            this.delete.Text = "DELETE DATA";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.CheckedChanged += new System.EventHandler(this.delete_CheckedChanged);
            // 
            // edit
            // 
            this.edit.AutoSize = true;
            this.edit.BackColor = System.Drawing.Color.SeaGreen;
            this.edit.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.edit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(48, 124);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(98, 20);
            this.edit.TabIndex = 27;
            this.edit.Text = "EDIT DATA";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.CheckedChanged += new System.EventHandler(this.edit_CheckedChanged);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.BackColor = System.Drawing.Color.SeaGreen;
            this.add.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.add.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(48, 75);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(94, 20);
            this.add.TabIndex = 26;
            this.add.Text = "ADD DATA";
            this.add.UseVisualStyleBackColor = true;
            this.add.CheckedChanged += new System.EventHandler(this.add_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.sensor);
            this.groupBox1.Controls.Add(this.agent);
            this.groupBox1.Controls.Add(this.service);
            this.groupBox1.Controls.Add(this.location);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Location = new System.Drawing.Point(128, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 214);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.view);
            this.groupBox2.Controls.Add(this.delete);
            this.groupBox2.Controls.Add(this.add);
            this.groupBox2.Controls.Add(this.edit);
            this.groupBox2.Location = new System.Drawing.Point(531, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 214);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // Form6Akila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.sss;
            this.ClientSize = new System.Drawing.Size(850, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.go);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form6Akila";
            this.Text = "EMS - Amend";
            this.Load += new System.EventHandler(this.Form6Akila_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton sensor;
        private System.Windows.Forms.RadioButton agent;
        private System.Windows.Forms.RadioButton service;
        private System.Windows.Forms.RadioButton location;
        private System.Windows.Forms.RadioButton user;
        private System.Windows.Forms.RadioButton view;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.RadioButton delete;
        private System.Windows.Forms.RadioButton edit;
        private System.Windows.Forms.RadioButton add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}