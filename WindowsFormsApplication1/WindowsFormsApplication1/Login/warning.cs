﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Login
{
    public partial class warning : Form
    {
        String msg;
        Form bb;
        public warning(String ss,Form aa)
        {
            msg = ss;
            bb = aa;
            InitializeComponent();
        }

        private void warning_Load(object sender, EventArgs e)
        {
            word.Text = msg;
            bb.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bb.Enabled = true;
            this.Close();

        }
    }
}
