namespace OutpatientRegistrationSystem
{
    partial class Frm_guahaodengji
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
            this.gb_patientInfo = new System.Windows.Forms.GroupBox();
            this.cb_keshi = new System.Windows.Forms.ComboBox();
            this.tb_yisheng = new System.Windows.Forms.TextBox();
            this.lb_yisheng = new System.Windows.Forms.Label();
            this.lb_keshi = new System.Windows.Forms.Label();
            this.cb_guahao = new System.Windows.Forms.ComboBox();
            this.cb_chufuzhen = new System.Windows.Forms.ComboBox();
            this.lb_chufuzhen = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tb_binglihao = new System.Windows.Forms.TextBox();
            this.lb_binglihao = new System.Windows.Forms.Label();
            this.lb_birthdate = new System.Windows.Forms.Label();
            this.tb_sex = new System.Windows.Forms.TextBox();
            this.lb_sex = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.bt_load = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_fapiaohao = new System.Windows.Forms.TextBox();
            this.lb_fapiaohao = new System.Windows.Forms.Label();
            this.rb_bingli = new System.Windows.Forms.RadioButton();
            this.rb_cika = new System.Windows.Forms.RadioButton();
            this.tb_kahao = new System.Windows.Forms.TextBox();
            this.lb_kahao = new System.Windows.Forms.Label();
            this.gb_pingzheng = new System.Windows.Forms.GroupBox();
            this.lb_leijijineshuju = new System.Windows.Forms.Label();
            this.lb_leijijine = new System.Windows.Forms.Label();
            this.lb_jineshuju = new System.Windows.Forms.Label();
            this.lb_jine = new System.Windows.Forms.Label();
            this.lb_end = new System.Windows.Forms.Label();
            this.lb_endtime = new System.Windows.Forms.Label();
            this.lb_start = new System.Windows.Forms.Label();
            this.lb_starttime = new System.Windows.Forms.Label();
            this.lb_pingzhenghaoshuju = new System.Windows.Forms.Label();
            this.lb_pingzhenghao = new System.Windows.Forms.Label();
            this.gn_yigua = new System.Windows.Forms.GroupBox();
            this.bt_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_guahao = new System.Windows.Forms.Button();
            this.bt_huanhao = new System.Windows.Forms.Button();
            this.bt_pingzhengxiugai = new System.Windows.Forms.Button();
            this.bt_tuichu = new System.Windows.Forms.Button();
            this.gb_patientInfo.SuspendLayout();
            this.gb_pingzheng.SuspendLayout();
            this.gn_yigua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_patientInfo
            // 
            this.gb_patientInfo.Controls.Add(this.cb_keshi);
            this.gb_patientInfo.Controls.Add(this.tb_yisheng);
            this.gb_patientInfo.Controls.Add(this.lb_yisheng);
            this.gb_patientInfo.Controls.Add(this.lb_keshi);
            this.gb_patientInfo.Controls.Add(this.cb_guahao);
            this.gb_patientInfo.Controls.Add(this.cb_chufuzhen);
            this.gb_patientInfo.Controls.Add(this.lb_chufuzhen);
            this.gb_patientInfo.Controls.Add(this.dateTimePicker1);
            this.gb_patientInfo.Controls.Add(this.tb_binglihao);
            this.gb_patientInfo.Controls.Add(this.lb_binglihao);
            this.gb_patientInfo.Controls.Add(this.lb_birthdate);
            this.gb_patientInfo.Controls.Add(this.tb_sex);
            this.gb_patientInfo.Controls.Add(this.lb_sex);
            this.gb_patientInfo.Controls.Add(this.tb_name);
            this.gb_patientInfo.Controls.Add(this.bt_load);
            this.gb_patientInfo.Controls.Add(this.lb_name);
            this.gb_patientInfo.Controls.Add(this.tb_fapiaohao);
            this.gb_patientInfo.Controls.Add(this.lb_fapiaohao);
            this.gb_patientInfo.Controls.Add(this.rb_bingli);
            this.gb_patientInfo.Controls.Add(this.rb_cika);
            this.gb_patientInfo.Controls.Add(this.tb_kahao);
            this.gb_patientInfo.Controls.Add(this.lb_kahao);
            this.gb_patientInfo.Location = new System.Drawing.Point(8, 8);
            this.gb_patientInfo.Name = "gb_patientInfo";
            this.gb_patientInfo.Size = new System.Drawing.Size(677, 111);
            this.gb_patientInfo.TabIndex = 0;
            this.gb_patientInfo.TabStop = false;
            this.gb_patientInfo.Text = "挂号登记 - 病人信息";
            this.gb_patientInfo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cb_keshi
            // 
            this.cb_keshi.FormattingEnabled = true;
            this.cb_keshi.Items.AddRange(new object[] {
            "中西医科",
            "口腔科",
            "妇科",
            "儿科",
            "耳鼻喉科",
            "骨伤科",
            "产科",
            "国医堂",
            "国医堂针推"});
            this.cb_keshi.Location = new System.Drawing.Point(360, 74);
            this.cb_keshi.Name = "cb_keshi";
            this.cb_keshi.Size = new System.Drawing.Size(93, 20);
            this.cb_keshi.TabIndex = 23;
            // 
            // tb_yisheng
            // 
            this.tb_yisheng.Location = new System.Drawing.Point(514, 73);
            this.tb_yisheng.Name = "tb_yisheng";
            this.tb_yisheng.Size = new System.Drawing.Size(147, 21);
            this.tb_yisheng.TabIndex = 22;
            // 
            // lb_yisheng
            // 
            this.lb_yisheng.AutoSize = true;
            this.lb_yisheng.Location = new System.Drawing.Point(472, 77);
            this.lb_yisheng.Name = "lb_yisheng";
            this.lb_yisheng.Size = new System.Drawing.Size(29, 12);
            this.lb_yisheng.TabIndex = 21;
            this.lb_yisheng.Text = "医生";
            // 
            // lb_keshi
            // 
            this.lb_keshi.AutoSize = true;
            this.lb_keshi.Location = new System.Drawing.Point(325, 77);
            this.lb_keshi.Name = "lb_keshi";
            this.lb_keshi.Size = new System.Drawing.Size(29, 12);
            this.lb_keshi.TabIndex = 19;
            this.lb_keshi.Text = "科室";
            // 
            // cb_guahao
            // 
            this.cb_guahao.FormattingEnabled = true;
            this.cb_guahao.Items.AddRange(new object[] {
            "1 - 普通挂号",
            "2 - 急诊挂号",
            "3 - 特殊挂号",
            "4 - 点名专家挂号",
            "5 - 义诊挂号",
            "6 - 外宾挂号",
            "7 - 挂号联动",
            "8 - 挂号作废",
            "9 - 换号",
            "10 - 新病人",
            "11 - 修改凭证",
            "12 - 修改当前收据号"});
            this.cb_guahao.Location = new System.Drawing.Point(209, 74);
            this.cb_guahao.Name = "cb_guahao";
            this.cb_guahao.Size = new System.Drawing.Size(110, 20);
            this.cb_guahao.TabIndex = 18;
            // 
            // cb_chufuzhen
            // 
            this.cb_chufuzhen.FormattingEnabled = true;
            this.cb_chufuzhen.Items.AddRange(new object[] {
            "1 - 复诊",
            "2 - 出诊"});
            this.cb_chufuzhen.Location = new System.Drawing.Point(71, 74);
            this.cb_chufuzhen.Name = "cb_chufuzhen";
            this.cb_chufuzhen.Size = new System.Drawing.Size(121, 20);
            this.cb_chufuzhen.TabIndex = 17;
            // 
            // lb_chufuzhen
            // 
            this.lb_chufuzhen.AutoSize = true;
            this.lb_chufuzhen.Location = new System.Drawing.Point(19, 77);
            this.lb_chufuzhen.Name = "lb_chufuzhen";
            this.lb_chufuzhen.Size = new System.Drawing.Size(41, 12);
            this.lb_chufuzhen.TabIndex = 16;
            this.lb_chufuzhen.Text = "初复诊";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(341, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 21);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(1987, 1, 1, 0, 0, 0, 0);
            // 
            // tb_binglihao
            // 
            this.tb_binglihao.Location = new System.Drawing.Point(514, 45);
            this.tb_binglihao.Name = "tb_binglihao";
            this.tb_binglihao.Size = new System.Drawing.Size(147, 21);
            this.tb_binglihao.TabIndex = 14;
            // 
            // lb_binglihao
            // 
            this.lb_binglihao.AutoSize = true;
            this.lb_binglihao.Location = new System.Drawing.Point(460, 49);
            this.lb_binglihao.Name = "lb_binglihao";
            this.lb_binglihao.Size = new System.Drawing.Size(41, 12);
            this.lb_binglihao.TabIndex = 13;
            this.lb_binglihao.Text = "病历号";
            // 
            // lb_birthdate
            // 
            this.lb_birthdate.AutoSize = true;
            this.lb_birthdate.Location = new System.Drawing.Point(286, 51);
            this.lb_birthdate.Name = "lb_birthdate";
            this.lb_birthdate.Size = new System.Drawing.Size(53, 12);
            this.lb_birthdate.TabIndex = 11;
            this.lb_birthdate.Text = "出生日期";
            // 
            // tb_sex
            // 
            this.tb_sex.Location = new System.Drawing.Point(242, 46);
            this.tb_sex.Name = "tb_sex";
            this.tb_sex.Size = new System.Drawing.Size(25, 21);
            this.tb_sex.TabIndex = 10;
            // 
            // lb_sex
            // 
            this.lb_sex.AutoSize = true;
            this.lb_sex.Location = new System.Drawing.Point(207, 51);
            this.lb_sex.Name = "lb_sex";
            this.lb_sex.Size = new System.Drawing.Size(29, 12);
            this.lb_sex.TabIndex = 9;
            this.lb_sex.Text = "性别";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(71, 46);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(124, 21);
            this.tb_name.TabIndex = 8;
            // 
            // bt_load
            // 
            this.bt_load.Location = new System.Drawing.Point(209, 15);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(47, 23);
            this.bt_load.TabIndex = 7;
            this.bt_load.Text = "载入";
            this.bt_load.UseVisualStyleBackColor = true;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(4, 49);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(53, 12);
            this.lb_name.TabIndex = 6;
            this.lb_name.Text = "患者姓名";
            // 
            // tb_fapiaohao
            // 
            this.tb_fapiaohao.Location = new System.Drawing.Point(514, 17);
            this.tb_fapiaohao.Name = "tb_fapiaohao";
            this.tb_fapiaohao.Size = new System.Drawing.Size(147, 21);
            this.tb_fapiaohao.TabIndex = 5;
            // 
            // lb_fapiaohao
            // 
            this.lb_fapiaohao.AutoSize = true;
            this.lb_fapiaohao.Location = new System.Drawing.Point(460, 20);
            this.lb_fapiaohao.Name = "lb_fapiaohao";
            this.lb_fapiaohao.Size = new System.Drawing.Size(41, 12);
            this.lb_fapiaohao.TabIndex = 4;
            this.lb_fapiaohao.Text = "发票号";
            // 
            // rb_bingli
            // 
            this.rb_bingli.AutoSize = true;
            this.rb_bingli.Location = new System.Drawing.Point(341, 19);
            this.rb_bingli.Name = "rb_bingli";
            this.rb_bingli.Size = new System.Drawing.Size(59, 16);
            this.rb_bingli.TabIndex = 3;
            this.rb_bingli.TabStop = true;
            this.rb_bingli.Text = "病历号";
            this.rb_bingli.UseVisualStyleBackColor = true;
            this.rb_bingli.CheckedChanged += new System.EventHandler(this.rb_bingli_CheckedChanged);
            // 
            // rb_cika
            // 
            this.rb_cika.AutoSize = true;
            this.rb_cika.Location = new System.Drawing.Point(288, 19);
            this.rb_cika.Name = "rb_cika";
            this.rb_cika.Size = new System.Drawing.Size(47, 16);
            this.rb_cika.TabIndex = 2;
            this.rb_cika.TabStop = true;
            this.rb_cika.Text = "磁卡";
            this.rb_cika.UseVisualStyleBackColor = true;
            // 
            // tb_kahao
            // 
            this.tb_kahao.Location = new System.Drawing.Point(71, 18);
            this.tb_kahao.Name = "tb_kahao";
            this.tb_kahao.Size = new System.Drawing.Size(124, 21);
            this.tb_kahao.TabIndex = 1;
            // 
            // lb_kahao
            // 
            this.lb_kahao.AutoSize = true;
            this.lb_kahao.Location = new System.Drawing.Point(28, 21);
            this.lb_kahao.Name = "lb_kahao";
            this.lb_kahao.Size = new System.Drawing.Size(29, 12);
            this.lb_kahao.TabIndex = 0;
            this.lb_kahao.Text = "卡号";
            this.lb_kahao.Click += new System.EventHandler(this.label1_Click);
            // 
            // gb_pingzheng
            // 
            this.gb_pingzheng.Controls.Add(this.lb_leijijineshuju);
            this.gb_pingzheng.Controls.Add(this.lb_leijijine);
            this.gb_pingzheng.Controls.Add(this.lb_jineshuju);
            this.gb_pingzheng.Controls.Add(this.lb_jine);
            this.gb_pingzheng.Controls.Add(this.lb_end);
            this.gb_pingzheng.Controls.Add(this.lb_endtime);
            this.gb_pingzheng.Controls.Add(this.lb_start);
            this.gb_pingzheng.Controls.Add(this.lb_starttime);
            this.gb_pingzheng.Controls.Add(this.lb_pingzhenghaoshuju);
            this.gb_pingzheng.Controls.Add(this.lb_pingzhenghao);
            this.gb_pingzheng.Location = new System.Drawing.Point(8, 126);
            this.gb_pingzheng.Name = "gb_pingzheng";
            this.gb_pingzheng.Size = new System.Drawing.Size(200, 262);
            this.gb_pingzheng.TabIndex = 1;
            this.gb_pingzheng.TabStop = false;
            this.gb_pingzheng.Text = "病人凭证信息";
            // 
            // lb_leijijineshuju
            // 
            this.lb_leijijineshuju.AutoSize = true;
            this.lb_leijijineshuju.Location = new System.Drawing.Point(71, 211);
            this.lb_leijijineshuju.Name = "lb_leijijineshuju";
            this.lb_leijijineshuju.Size = new System.Drawing.Size(35, 12);
            this.lb_leijijineshuju.TabIndex = 9;
            this.lb_leijijineshuju.Text = "[0.0]";
            // 
            // lb_leijijine
            // 
            this.lb_leijijine.AutoSize = true;
            this.lb_leijijine.Location = new System.Drawing.Point(7, 211);
            this.lb_leijijine.Name = "lb_leijijine";
            this.lb_leijijine.Size = new System.Drawing.Size(53, 12);
            this.lb_leijijine.TabIndex = 8;
            this.lb_leijijine.Text = "累计金额";
            // 
            // lb_jineshuju
            // 
            this.lb_jineshuju.AutoSize = true;
            this.lb_jineshuju.Location = new System.Drawing.Point(71, 175);
            this.lb_jineshuju.Name = "lb_jineshuju";
            this.lb_jineshuju.Size = new System.Drawing.Size(35, 12);
            this.lb_jineshuju.TabIndex = 7;
            this.lb_jineshuju.Text = "[0.0]";
            // 
            // lb_jine
            // 
            this.lb_jine.AutoSize = true;
            this.lb_jine.Location = new System.Drawing.Point(12, 176);
            this.lb_jine.Name = "lb_jine";
            this.lb_jine.Size = new System.Drawing.Size(53, 12);
            this.lb_jine.TabIndex = 6;
            this.lb_jine.Text = "账户金额";
            // 
            // lb_end
            // 
            this.lb_end.AutoSize = true;
            this.lb_end.Location = new System.Drawing.Point(73, 129);
            this.lb_end.Name = "lb_end";
            this.lb_end.Size = new System.Drawing.Size(53, 12);
            this.lb_end.TabIndex = 5;
            this.lb_end.Text = "结束时间";
            // 
            // lb_endtime
            // 
            this.lb_endtime.AutoSize = true;
            this.lb_endtime.Location = new System.Drawing.Point(10, 129);
            this.lb_endtime.Name = "lb_endtime";
            this.lb_endtime.Size = new System.Drawing.Size(53, 12);
            this.lb_endtime.TabIndex = 4;
            this.lb_endtime.Text = "结束时间";
            // 
            // lb_start
            // 
            this.lb_start.AutoSize = true;
            this.lb_start.Location = new System.Drawing.Point(71, 86);
            this.lb_start.Name = "lb_start";
            this.lb_start.Size = new System.Drawing.Size(53, 12);
            this.lb_start.TabIndex = 3;
            this.lb_start.Text = "开始时间";
            // 
            // lb_starttime
            // 
            this.lb_starttime.AutoSize = true;
            this.lb_starttime.Location = new System.Drawing.Point(8, 87);
            this.lb_starttime.Name = "lb_starttime";
            this.lb_starttime.Size = new System.Drawing.Size(53, 12);
            this.lb_starttime.TabIndex = 2;
            this.lb_starttime.Text = "开始时间";
            // 
            // lb_pingzhenghaoshuju
            // 
            this.lb_pingzhenghaoshuju.AutoSize = true;
            this.lb_pingzhenghaoshuju.Location = new System.Drawing.Point(71, 37);
            this.lb_pingzhenghaoshuju.Name = "lb_pingzhenghaoshuju";
            this.lb_pingzhenghaoshuju.Size = new System.Drawing.Size(65, 12);
            this.lb_pingzhenghaoshuju.TabIndex = 1;
            this.lb_pingzhenghaoshuju.Text = "凭证号数据";
            // 
            // lb_pingzhenghao
            // 
            this.lb_pingzhenghao.AutoSize = true;
            this.lb_pingzhenghao.Location = new System.Drawing.Point(20, 37);
            this.lb_pingzhenghao.Name = "lb_pingzhenghao";
            this.lb_pingzhenghao.Size = new System.Drawing.Size(41, 12);
            this.lb_pingzhenghao.TabIndex = 0;
            this.lb_pingzhenghao.Text = "凭证号";
            // 
            // gn_yigua
            // 
            this.gn_yigua.Controls.Add(this.bt_delete);
            this.gn_yigua.Controls.Add(this.dataGridView1);
            this.gn_yigua.Location = new System.Drawing.Point(215, 126);
            this.gn_yigua.Name = "gn_yigua";
            this.gn_yigua.Size = new System.Drawing.Size(470, 262);
            this.gn_yigua.TabIndex = 2;
            this.gn_yigua.TabStop = false;
            this.gn_yigua.Text = "已挂科室/专家信息";
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(6, 231);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(458, 23);
            this.bt_delete.TabIndex = 1;
            this.bt_delete.Text = "删除当前科室/专家";
            this.bt_delete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(468, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_guahao
            // 
            this.bt_guahao.Location = new System.Drawing.Point(252, 394);
            this.bt_guahao.Name = "bt_guahao";
            this.bt_guahao.Size = new System.Drawing.Size(75, 23);
            this.bt_guahao.TabIndex = 3;
            this.bt_guahao.Text = "挂号";
            this.bt_guahao.UseVisualStyleBackColor = true;
            // 
            // bt_huanhao
            // 
            this.bt_huanhao.Location = new System.Drawing.Point(368, 394);
            this.bt_huanhao.Name = "bt_huanhao";
            this.bt_huanhao.Size = new System.Drawing.Size(75, 23);
            this.bt_huanhao.TabIndex = 4;
            this.bt_huanhao.Text = "换号";
            this.bt_huanhao.UseVisualStyleBackColor = true;
            this.bt_huanhao.Click += new System.EventHandler(this.bt_huanhao_Click);
            // 
            // bt_pingzhengxiugai
            // 
            this.bt_pingzhengxiugai.Location = new System.Drawing.Point(482, 394);
            this.bt_pingzhengxiugai.Name = "bt_pingzhengxiugai";
            this.bt_pingzhengxiugai.Size = new System.Drawing.Size(75, 23);
            this.bt_pingzhengxiugai.TabIndex = 6;
            this.bt_pingzhengxiugai.Text = "凭证修改";
            this.bt_pingzhengxiugai.UseVisualStyleBackColor = true;
            // 
            // bt_tuichu
            // 
            this.bt_tuichu.Location = new System.Drawing.Point(604, 394);
            this.bt_tuichu.Name = "bt_tuichu";
            this.bt_tuichu.Size = new System.Drawing.Size(75, 23);
            this.bt_tuichu.TabIndex = 7;
            this.bt_tuichu.Text = "退出";
            this.bt_tuichu.UseVisualStyleBackColor = true;
            this.bt_tuichu.Click += new System.EventHandler(this.bt_tuichu_Click);
            // 
            // Frm_guahaodengji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 461);
            this.Controls.Add(this.bt_tuichu);
            this.Controls.Add(this.bt_pingzhengxiugai);
            this.Controls.Add(this.bt_huanhao);
            this.Controls.Add(this.bt_guahao);
            this.Controls.Add(this.gn_yigua);
            this.Controls.Add(this.gb_pingzheng);
            this.Controls.Add(this.gb_patientInfo);
            this.Name = "Frm_guahaodengji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "挂号登记";
            this.gb_patientInfo.ResumeLayout(false);
            this.gb_patientInfo.PerformLayout();
            this.gb_pingzheng.ResumeLayout(false);
            this.gb_pingzheng.PerformLayout();
            this.gn_yigua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_patientInfo;
        private System.Windows.Forms.Label lb_kahao;
        private System.Windows.Forms.TextBox tb_kahao;
        private System.Windows.Forms.Label lb_fapiaohao;
        private System.Windows.Forms.RadioButton rb_bingli;
        private System.Windows.Forms.RadioButton rb_cika;
        private System.Windows.Forms.Button bt_load;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_birthdate;
        private System.Windows.Forms.TextBox tb_sex;
        private System.Windows.Forms.Label lb_sex;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_fapiaohao;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tb_binglihao;
        private System.Windows.Forms.Label lb_binglihao;
        private System.Windows.Forms.ComboBox cb_keshi;
        private System.Windows.Forms.TextBox tb_yisheng;
        private System.Windows.Forms.Label lb_yisheng;
        private System.Windows.Forms.Label lb_keshi;
        private System.Windows.Forms.ComboBox cb_guahao;
        private System.Windows.Forms.ComboBox cb_chufuzhen;
        private System.Windows.Forms.Label lb_chufuzhen;
        private System.Windows.Forms.GroupBox gb_pingzheng;
        private System.Windows.Forms.GroupBox gn_yigua;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_guahao;
        private System.Windows.Forms.Button bt_huanhao;
        private System.Windows.Forms.Button bt_pingzhengxiugai;
        private System.Windows.Forms.Button bt_tuichu;
        private System.Windows.Forms.Label lb_leijijineshuju;
        private System.Windows.Forms.Label lb_leijijine;
        private System.Windows.Forms.Label lb_jineshuju;
        private System.Windows.Forms.Label lb_jine;
        private System.Windows.Forms.Label lb_end;
        private System.Windows.Forms.Label lb_endtime;
        private System.Windows.Forms.Label lb_start;
        private System.Windows.Forms.Label lb_starttime;
        private System.Windows.Forms.Label lb_pingzhenghaoshuju;
        private System.Windows.Forms.Label lb_pingzhenghao;
    }
}