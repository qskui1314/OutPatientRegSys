using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OutpatientRegistrationSystem
{
    public partial class Frm_infoReg : Form
    {
        public Frm_infoReg()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void Frm_infoReg_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}
