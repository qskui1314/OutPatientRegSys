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
    public partial class Frm_patient : Form
    {
        public Frm_patient()
        {
            InitializeComponent();
        }

        private void Frm_patient_Load(object sender, EventArgs e)
        {
            //添加性别
            cmb_sex.Items.Add("男");
            cmb_sex.Items.Add("女");
            cmb_sex.SelectedIndex = 0;

            cmb_cardtype.Items.Add("医疗卡");
            cmb_cardtype.Items.Add("社保卡");
            cmb_cardtype.SelectedIndex = 0;

            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void initAdd()
        {
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;

            //清除原有值
            tb_address.Text = "";
            tb_age.Text = "";
            tb_balance.Text = "";
            tb_cardNo.Text = "";
            tb_cellphone.Text = "";
            tb_creditlimit.Text = "";
            tb_email.Text = "";
            tb_firstman.Text = "";
            tb_firstphone.Text = "";
            tb_hispass.Text = "";
            tb_id.Text = "";
            tb_name.Text = "";
            tb_nation.Text = "";
            tb_nationality.Text = "";
            tb_operate.Text = "";
            tb_patientNo.Text = "";

            btn_addpatient.Text = "保存添加";
        }

        private void btn_addpatient_Click(object sender, EventArgs e)
        {
            if (btn_addpatient.Text == "添加病人")
            {
                this.initAdd();
            }
            else
            {

                btn_addpatient.Text = "添加病人";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请插入社保卡!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
