namespace WindowsFormsApplication1
{
    partial class Dtable
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dtable));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emsDataSet = new WindowsFormsApplication1.emsDataSet();
            this.usersTableAdapter = new WindowsFormsApplication1.emsDataSetTableAdapters.usersTableAdapter();
            this.allData = new System.Windows.Forms.DataGridView();
            this.LocationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RainFall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.helloDataSet = new WindowsFormsApplication1.HelloDataSet();
            this.helloDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helloDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = global::WindowsFormsApplication1.Properties.Resources.sss;
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(851, 478);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(325, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "RETRIEVE DATA";
            // 
            // button2
            // 
            this.button2.Image = global::WindowsFormsApplication1.Properties.Resources.images;
            this.button2.Location = new System.Drawing.Point(414, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.emsDataSet;
            // 
            // emsDataSet
            // 
            this.emsDataSet.DataSetName = "emsDataSet";
            this.emsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // allData
            // 
            this.allData.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.allData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocationID,
            this.Temperature,
            this.RainFall,
            this.Humidity,
            this.CO2});
            this.allData.Location = new System.Drawing.Point(121, 81);
            this.allData.Name = "allData";
            this.allData.Size = new System.Drawing.Size(544, 285);
            this.allData.TabIndex = 13;
            // 
            // LocationID
            // 
            this.LocationID.HeaderText = "Location";
            this.LocationID.Name = "LocationID";
            this.LocationID.ReadOnly = true;
            // 
            // Temperature
            // 
            this.Temperature.HeaderText = "Temperature";
            this.Temperature.Name = "Temperature";
            this.Temperature.ReadOnly = true;
            // 
            // RainFall
            // 
            this.RainFall.HeaderText = "Rain Fall";
            this.RainFall.Name = "RainFall";
            this.RainFall.ReadOnly = true;
            // 
            // Humidity
            // 
            this.Humidity.HeaderText = "Humidity";
            this.Humidity.Name = "Humidity";
            this.Humidity.ReadOnly = true;
            // 
            // CO2
            // 
            this.CO2.HeaderText = "CO2";
            this.CO2.Name = "CO2";
            this.CO2.ReadOnly = true;
            // 
            // emsDataSetBindingSource
            // 
            this.emsDataSetBindingSource.DataSource = this.emsDataSet;
            this.emsDataSetBindingSource.Position = 0;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.emsDataSet;
            // 
            // helloDataSet
            // 
            this.helloDataSet.DataSetName = "HelloDataSet";
            this.helloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // helloDataSetBindingSource
            // 
            this.helloDataSetBindingSource.DataSource = this.helloDataSet;
            this.helloDataSetBindingSource.Position = 0;
            // 
            // Dtable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 473);
            this.Controls.Add(this.allData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dtable";
            this.Text = "EMS - Current Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helloDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private emsDataSet emsDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private emsDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridView allData;
        private System.Windows.Forms.BindingSource emsDataSetBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private HelloDataSet helloDataSet;
        private System.Windows.Forms.BindingSource helloDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn RainFall;
        private System.Windows.Forms.DataGridViewTextBoxColumn Humidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CO2;

    }
}

