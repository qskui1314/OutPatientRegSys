namespace OutpatientRegistrationSystem
{
    partial class Frm_huanhao
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
            this.lb_kahao = new System.Windows.Forms.Label();
            this.tb_kahao = new System.Windows.Forms.TextBox();
            this.lb_binglihao = new System.Windows.Forms.Label();
            this.tb_binglihao = new System.Windows.Forms.TextBox();
            this.bt_chaxun = new System.Windows.Forms.Button();
            this.bt_tuichu = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.lbl_start = new System.Windows.Forms.Label();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.lbl_end = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dgv_baseinfo = new System.Windows.Forms.DataGridView();
            this.dgv_keshi = new System.Windows.Forms.DataGridView();
            this.lbl_yuankeshi = new System.Windows.Forms.Label();
            this.tbx_yuankeshi = new System.Windows.Forms.TextBox();
            this.lbl_tihuankeshi = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_更新 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baseinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_keshi)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_kahao
            // 
            this.lb_kahao.AutoSize = true;
            this.lb_kahao.Location = new System.Drawing.Point(21, 10);
            this.lb_kahao.Name = "lb_kahao";
            this.lb_kahao.Size = new System.Drawing.Size(29, 12);
            this.lb_kahao.TabIndex = 0;
            this.lb_kahao.Text = "卡号";
            this.lb_kahao.Click += new System.EventHandler(this.lb_kahao_Click);
            // 
            // tb_kahao
            // 
            this.tb_kahao.Location = new System.Drawing.Point(82, 7);
            this.tb_kahao.Name = "tb_kahao";
            this.tb_kahao.Size = new System.Drawing.Size(190, 21);
            this.tb_kahao.TabIndex = 1;
            // 
            // lb_binglihao
            // 
            this.lb_binglihao.AutoSize = true;
            this.lb_binglihao.Location = new System.Drawing.Point(402, 10);
            this.lb_binglihao.Name = "lb_binglihao";
            this.lb_binglihao.Size = new System.Drawing.Size(41, 12);
            this.lb_binglihao.TabIndex = 2;
            this.lb_binglihao.Text = "病历号";
            // 
            // tb_binglihao
            // 
            this.tb_binglihao.Location = new System.Drawing.Point(460, 7);
            this.tb_binglihao.Name = "tb_binglihao";
            this.tb_binglihao.Size = new System.Drawing.Size(227, 21);
            this.tb_binglihao.TabIndex = 3;
            // 
            // bt_chaxun
            // 
            this.bt_chaxun.Location = new System.Drawing.Point(288, 4);
            this.bt_chaxun.Name = "bt_chaxun";
            this.bt_chaxun.Size = new System.Drawing.Size(75, 23);
            this.bt_chaxun.TabIndex = 4;
            this.bt_chaxun.Text = "查询";
            this.bt_chaxun.UseVisualStyleBackColor = true;
            // 
            // bt_tuichu
            // 
            this.bt_tuichu.Location = new System.Drawing.Point(534, 408);
            this.bt_tuichu.Name = "bt_tuichu";
            this.bt_tuichu.Size = new System.Drawing.Size(132, 23);
            this.bt_tuichu.TabIndex = 5;
            this.bt_tuichu.Text = "退出";
            this.bt_tuichu.UseVisualStyleBackColor = true;
            this.bt_tuichu.Click += new System.EventHandler(this.bt_tuichu_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(23, 38);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(53, 12);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "患者姓名";
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(82, 35);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(121, 21);
            this.txb_name.TabIndex = 7;
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(231, 38);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(53, 12);
            this.lbl_start.TabIndex = 8;
            this.lbl_start.Text = "开始时间";
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(288, 35);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(142, 21);
            this.dtp_start.TabIndex = 9;
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(458, 41);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(53, 12);
            this.lbl_end.TabIndex = 10;
            this.lbl_end.Text = "结束时间";
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(524, 35);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(163, 21);
            this.dtp_end.TabIndex = 11;
            // 
            // dgv_baseinfo
            // 
            this.dgv_baseinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_baseinfo.Location = new System.Drawing.Point(3, 62);
            this.dgv_baseinfo.Name = "dgv_baseinfo";
            this.dgv_baseinfo.RowTemplate.Height = 23;
            this.dgv_baseinfo.Size = new System.Drawing.Size(694, 176);
            this.dgv_baseinfo.TabIndex = 12;
            // 
            // dgv_keshi
            // 
            this.dgv_keshi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_keshi.Location = new System.Drawing.Point(2, 249);
            this.dgv_keshi.Name = "dgv_keshi";
            this.dgv_keshi.RowTemplate.Height = 23;
            this.dgv_keshi.Size = new System.Drawing.Size(332, 212);
            this.dgv_keshi.TabIndex = 13;
            // 
            // lbl_yuankeshi
            // 
            this.lbl_yuankeshi.AutoSize = true;
            this.lbl_yuankeshi.Location = new System.Drawing.Point(377, 269);
            this.lbl_yuankeshi.Name = "lbl_yuankeshi";
            this.lbl_yuankeshi.Size = new System.Drawing.Size(41, 12);
            this.lbl_yuankeshi.TabIndex = 14;
            this.lbl_yuankeshi.Text = "原科室";
            // 
            // tbx_yuankeshi
            // 
            this.tbx_yuankeshi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_yuankeshi.Location = new System.Drawing.Point(379, 298);
            this.tbx_yuankeshi.Name = "tbx_yuankeshi";
            this.tbx_yuankeshi.Size = new System.Drawing.Size(287, 14);
            this.tbx_yuankeshi.TabIndex = 15;
            // 
            // lbl_tihuankeshi
            // 
            this.lbl_tihuankeshi.AutoSize = true;
            this.lbl_tihuankeshi.Location = new System.Drawing.Point(377, 330);
            this.lbl_tihuankeshi.Name = "lbl_tihuankeshi";
            this.lbl_tihuankeshi.Size = new System.Drawing.Size(77, 12);
            this.lbl_tihuankeshi.TabIndex = 16;
            this.lbl_tihuankeshi.Text = "选择替换科室";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(379, 345);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 21);
            this.textBox2.TabIndex = 17;
            // 
            // btn_更新
            // 
            this.btn_更新.Location = new System.Drawing.Point(379, 408);
            this.btn_更新.Name = "btn_更新";
            this.btn_更新.Size = new System.Drawing.Size(132, 23);
            this.btn_更新.TabIndex = 18;
            this.btn_更新.Text = "更新";
            this.btn_更新.UseVisualStyleBackColor = true;
            // 
            // Frm_huanhao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 461);
            this.Controls.Add(this.btn_更新);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_tihuankeshi);
            this.Controls.Add(this.tbx_yuankeshi);
            this.Controls.Add(this.lbl_yuankeshi);
            this.Controls.Add(this.dgv_keshi);
            this.Controls.Add(this.dgv_baseinfo);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.bt_tuichu);
            this.Controls.Add(this.bt_chaxun);
            this.Controls.Add(this.tb_binglihao);
            this.Controls.Add(this.lb_binglihao);
            this.Controls.Add(this.tb_kahao);
            this.Controls.Add(this.lb_kahao);
            this.Name = "Frm_huanhao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "换号";
            this.Load += new System.EventHandler(this.Frm_huanhao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baseinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_keshi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_kahao;
        private System.Windows.Forms.TextBox tb_kahao;
        private System.Windows.Forms.Label lb_binglihao;
        private System.Windows.Forms.TextBox tb_binglihao;
        private System.Windows.Forms.Button bt_chaxun;
        private System.Windows.Forms.Button bt_tuichu;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DataGridView dgv_baseinfo;
        private System.Windows.Forms.DataGridView dgv_keshi;
        private System.Windows.Forms.Label lbl_yuankeshi;
        private System.Windows.Forms.TextBox tbx_yuankeshi;
        private System.Windows.Forms.Label lbl_tihuankeshi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_更新;
    }
}