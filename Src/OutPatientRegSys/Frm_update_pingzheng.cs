﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OutpatientRegistrationSystem
{
    public partial class Frm_update_pingzheng : Form
    {
        public Frm_update_pingzheng()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btn_退出_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
