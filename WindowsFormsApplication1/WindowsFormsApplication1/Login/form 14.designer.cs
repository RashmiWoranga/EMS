namespace WindowsFormsApplication1
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.privililage = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.psword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.psword1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // privililage
            // 
            this.privililage.BackColor = System.Drawing.Color.SeaGreen;
            this.privililage.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privililage.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.privililage.FormattingEnabled = true;
            this.privililage.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.privililage.Location = new System.Drawing.Point(312, 270);
            this.privililage.Name = "privililage";
            this.privililage.Size = new System.Drawing.Size(285, 24);
            this.privililage.TabIndex = 70;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.SeaShell;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(312, 112);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(285, 14);
            this.name.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.SeaGreen;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(110, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 67;
            this.label11.Text = "User Name";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SeaGreen;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(110, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Privilage Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(350, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 60;
            this.label3.Text = "User Details";
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Image = global::WindowsFormsApplication1.Properties.Resources.tango_go_top_115953;
            this.logout.Location = new System.Drawing.Point(744, 375);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(50, 50);
            this.logout.TabIndex = 73;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Image = global::WindowsFormsApplication1.Properties.Resources._1363526619_ark2;
            this.ok.Location = new System.Drawing.Point(413, 375);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(50, 50);
            this.ok.TabIndex = 72;
            this.ok.Text = "Save";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::WindowsFormsApplication1.Properties.Resources.tango_go_previous_115999;
            this.button2.Location = new System.Drawing.Point(55, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 71;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Image = global::WindowsFormsApplication1.Properties.Resources.sss;
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(853, 482);
            this.label1.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "Password";
            // 
            // psword
            // 
            this.psword.BackColor = System.Drawing.Color.SeaShell;
            this.psword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.psword.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psword.ForeColor = System.Drawing.Color.Black;
            this.psword.Location = new System.Drawing.Point(312, 172);
            this.psword.Name = "psword";
            this.psword.Size = new System.Drawing.Size(285, 14);
            this.psword.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SeaGreen;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(110, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 76;
            this.label5.Text = "Retype Password";
            // 
            // psword1
            // 
            this.psword1.BackColor = System.Drawing.Color.SeaShell;
            this.psword1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.psword1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psword1.ForeColor = System.Drawing.Color.Black;
            this.psword1.Location = new System.Drawing.Point(312, 226);
            this.psword1.Name = "psword1";
            this.psword1.Size = new System.Drawing.Size(285, 14);
            this.psword1.TabIndex = 77;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 480);
            this.Controls.Add(this.psword1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.psword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.privililage);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form14";
            this.Text = "EMS - Add User";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox privililage;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox psword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox psword1;

    }
}