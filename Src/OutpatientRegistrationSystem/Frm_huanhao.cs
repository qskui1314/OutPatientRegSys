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
    public partial class Frm_huanhao : Form
    {
        public Frm_huanhao()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void Frm_huanhao_Load(object sender, EventArgs e)
        {

        }

        private void bt_tuichu_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}
