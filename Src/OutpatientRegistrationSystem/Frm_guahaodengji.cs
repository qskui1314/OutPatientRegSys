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
    public partial class Frm_guahaodengji : Form
    {
        public Frm_guahaodengji()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rb_bingli_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_tuichu_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void bt_huanhao_Click(object sender, EventArgs e)
        {
            Frm_huanhao frm_huanhao = new Frm_huanhao();
            this.Hide();
            if (frm_huanhao.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
