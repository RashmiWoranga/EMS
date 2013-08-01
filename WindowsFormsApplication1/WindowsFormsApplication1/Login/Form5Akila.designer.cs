namespace WindowsFormsApplication1
{
    partial class Form5Akila
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
            this.label2 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.RadioButton();
            this.edit = new System.Windows.Forms.RadioButton();
            this.add = new System.Windows.Forms.RadioButton();
            this.logout = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(136, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ADDING,EDITTING AND DELETING DETAILS";
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.BackColor = System.Drawing.Color.SeaGreen;
            this.delete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(195, 219);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(116, 20);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete details";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // edit
            // 
            this.edit.AutoSize = true;
            this.edit.BackColor = System.Drawing.Color.SeaGreen;
            this.edit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(195, 164);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(99, 20);
            this.edit.TabIndex = 7;
            this.edit.Text = "Edit details";
            this.edit.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.BackColor = System.Drawing.Color.SeaGreen;
            this.add.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.add.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(195, 109);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(99, 20);
            this.add.TabIndex = 6;
            this.add.Text = "Add details";
            this.add.UseVisualStyleBackColor = false;
            this.add.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Image = global::WindowsFormsApplication1.Properties.Resources.tango_go_top_115953;
            this.logout.Location = new System.Drawing.Point(772, 399);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(50, 50);
            this.logout.TabIndex = 11;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // go
            // 
            this.go.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.Image = global::WindowsFormsApplication1.Properties.Resources.tango_go_next_115997;
            this.go.Location = new System.Drawing.Point(544, 400);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(50, 50);
            this.go.TabIndex = 10;
            this.go.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Image = global::WindowsFormsApplication1.Properties.Resources.tango_go_previous_115999;
            this.back.Location = new System.Drawing.Point(27, 400);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(50, 50);
            this.back.TabIndex = 9;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Image = global::WindowsFormsApplication1.Properties.Resources.eco_friendly_background;
            this.label1.Location = new System.Drawing.Point(1, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(833, 471);
            this.label1.TabIndex = 1;
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Image = global::WindowsFormsApplication1.Properties.Resources.refresh;
            this.refresh.Location = new System.Drawing.Point(298, 399);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(50, 50);
            this.refresh.TabIndex = 12;
            this.refresh.UseVisualStyleBackColor = true;
            // 
            // Form5Akila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 462);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.go);
            this.Controls.Add(this.back);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5Akila";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton delete;
        private System.Windows.Forms.RadioButton edit;
        private System.Windows.Forms.RadioButton add;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button refresh;
    }
}