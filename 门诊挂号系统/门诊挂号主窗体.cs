using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 门诊挂号系统
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsc_1_1_Click(object sender, EventArgs e)
        {
            frm_BaseInfoReg frm_BaseInfoReg = new frm_BaseInfoReg();
            this.Hide();
            if (frm_BaseInfoReg.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
