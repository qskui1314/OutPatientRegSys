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
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("您确定要退出系统吗?", "退出确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void menu_基本信息登记_Click(object sender, EventArgs e)
        {
            Frm_infoReg frm_infoReg = new Frm_infoReg();
            this.Hide();
            if (frm_infoReg.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void Frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menu_挂号登记_Click(object sender, EventArgs e)
        {
            Frm_guahaodengji frm_guahaodengji = new Frm_guahaodengji();
            this.Hide();
            if (frm_guahaodengji.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void menu_特殊挂号_Click(object sender, EventArgs e)
        {
            Frm_guahaodengji frm_guahaodengji = new Frm_guahaodengji();
            this.Hide();
            if (frm_guahaodengji.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void menu_点名专家挂号_Click(object sender, EventArgs e)
        {
            Frm_guahaodengji frm_guahaodengji = new Frm_guahaodengji();
            this.Hide();
            if (frm_guahaodengji.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void menu_外宾挂号_Click(object sender, EventArgs e)
        {
            Frm_guahaodengji frm_guahaodengji = new Frm_guahaodengji();
            this.Hide();
            if (frm_guahaodengji.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void menu_免挂号费挂号_Click(object sender, EventArgs e)
        {
            Frm_guahaodengji frm_guahaodengji = new Frm_guahaodengji();
            this.Hide();
            if (frm_guahaodengji.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void menu_免费挂号_Click(object sender, EventArgs e)
        {
            Frm_guahaodengji frm_guahaodengji = new Frm_guahaodengji();
            this.Hide();
            if (frm_guahaodengji.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void 关于开发者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "https://github.com/qskui1314");
        }

        private void menu_医保凭证修改_Click(object sender, EventArgs e)
        {
            Frm_update_pingzheng frm_Update_Pingzheng = new Frm_update_pingzheng();
            this.Hide();
            if (frm_Update_Pingzheng.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
