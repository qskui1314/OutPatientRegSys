namespace OutpatientRegistrationSystem
{
    partial class Frm_patient
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_name = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_regno = new System.Windows.Forms.Button();
            this.btn_appointment = new System.Windows.Forms.Button();
            this.btn_modifypatient = new System.Windows.Forms.Button();
            this.btn_addpatient = new System.Windows.Forms.Button();
            this.txt_operate = new System.Windows.Forms.TextBox();
            this.txt_hispass = new System.Windows.Forms.TextBox();
            this.cmb_cardtype = new System.Windows.Forms.ComboBox();
            this.txt_creditlimit = new System.Windows.Forms.TextBox();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.txt_firstaddress = new System.Windows.Forms.TextBox();
            this.txt_firstphone = new System.Windows.Forms.TextBox();
            this.cmb_firstquery = new System.Windows.Forms.ComboBox();
            this.txt_firstman = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_companyname = new System.Windows.Forms.TextBox();
            this.txt_companyphone = new System.Windows.Forms.TextBox();
            this.txt_homephone = new System.Windows.Forms.TextBox();
            this.txt_cellphone = new System.Windows.Forms.TextBox();
            this.txt_homeaddress = new System.Windows.Forms.TextBox();
            this.txt_celladdress = new System.Windows.Forms.TextBox();
            this.txt_sidno = new System.Windows.Forms.TextBox();
            this.cmb_sidtype = new System.Windows.Forms.ComboBox();
            this.dtp_recdate = new System.Windows.Forms.DateTimePicker();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.cmb_sex = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_docoperate = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(88, 71);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(164, 21);
            this.txt_name.TabIndex = 96;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cmb_name,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1047, 25);
            this.toolStrip1.TabIndex = 95;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(140, 22);
            this.toolStripLabel1.Text = "快速查找已有病人资料：";
            // 
            // cmb_name
            // 
            this.cmb_name.Name = "cmb_name";
            this.cmb_name.Size = new System.Drawing.Size(180, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(116, 22);
            this.toolStripLabel2.Text = "输入姓名将自动检索";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_regno);
            this.groupBox1.Controls.Add(this.btn_appointment);
            this.groupBox1.Controls.Add(this.btn_modifypatient);
            this.groupBox1.Controls.Add(this.btn_addpatient);
            this.groupBox1.Location = new System.Drawing.Point(622, 515);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(396, 126);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作类型";
            // 
            // btn_regno
            // 
            this.btn_regno.Location = new System.Drawing.Point(226, 74);
            this.btn_regno.Margin = new System.Windows.Forms.Padding(4);
            this.btn_regno.Name = "btn_regno";
            this.btn_regno.Size = new System.Drawing.Size(112, 40);
            this.btn_regno.TabIndex = 3;
            this.btn_regno.Text = "病人挂号";
            this.btn_regno.UseVisualStyleBackColor = true;
            // 
            // btn_appointment
            // 
            this.btn_appointment.Location = new System.Drawing.Point(226, 26);
            this.btn_appointment.Margin = new System.Windows.Forms.Padding(4);
            this.btn_appointment.Name = "btn_appointment";
            this.btn_appointment.Size = new System.Drawing.Size(112, 39);
            this.btn_appointment.TabIndex = 2;
            this.btn_appointment.Text = "病人预约";
            this.btn_appointment.UseVisualStyleBackColor = true;
            // 
            // btn_modifypatient
            // 
            this.btn_modifypatient.Location = new System.Drawing.Point(63, 75);
            this.btn_modifypatient.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modifypatient.Name = "btn_modifypatient";
            this.btn_modifypatient.Size = new System.Drawing.Size(106, 40);
            this.btn_modifypatient.TabIndex = 1;
            this.btn_modifypatient.Text = "修改病人";
            this.btn_modifypatient.UseVisualStyleBackColor = true;
            // 
            // btn_addpatient
            // 
            this.btn_addpatient.Location = new System.Drawing.Point(62, 27);
            this.btn_addpatient.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addpatient.Name = "btn_addpatient";
            this.btn_addpatient.Size = new System.Drawing.Size(106, 40);
            this.btn_addpatient.TabIndex = 0;
            this.btn_addpatient.Text = "添加病人";
            this.btn_addpatient.UseVisualStyleBackColor = true;
            // 
            // txt_operate
            // 
            this.txt_operate.Location = new System.Drawing.Point(692, 351);
            this.txt_operate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_operate.Multiline = true;
            this.txt_operate.Name = "txt_operate";
            this.txt_operate.Size = new System.Drawing.Size(312, 152);
            this.txt_operate.TabIndex = 93;
            // 
            // txt_hispass
            // 
            this.txt_hispass.Location = new System.Drawing.Point(692, 165);
            this.txt_hispass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hispass.Multiline = true;
            this.txt_hispass.Name = "txt_hispass";
            this.txt_hispass.Size = new System.Drawing.Size(312, 136);
            this.txt_hispass.TabIndex = 92;
            // 
            // cmb_cardtype
            // 
            this.cmb_cardtype.FormattingEnabled = true;
            this.cmb_cardtype.Location = new System.Drawing.Point(434, 497);
            this.cmb_cardtype.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_cardtype.Name = "cmb_cardtype";
            this.cmb_cardtype.Size = new System.Drawing.Size(162, 20);
            this.cmb_cardtype.TabIndex = 91;
            // 
            // txt_creditlimit
            // 
            this.txt_creditlimit.Location = new System.Drawing.Point(435, 561);
            this.txt_creditlimit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_creditlimit.Name = "txt_creditlimit";
            this.txt_creditlimit.Size = new System.Drawing.Size(160, 21);
            this.txt_creditlimit.TabIndex = 90;
            // 
            // txt_balance
            // 
            this.txt_balance.Location = new System.Drawing.Point(138, 609);
            this.txt_balance.Margin = new System.Windows.Forms.Padding(4);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(174, 21);
            this.txt_balance.TabIndex = 89;
            // 
            // txt_firstaddress
            // 
            this.txt_firstaddress.Location = new System.Drawing.Point(138, 555);
            this.txt_firstaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txt_firstaddress.Name = "txt_firstaddress";
            this.txt_firstaddress.Size = new System.Drawing.Size(174, 21);
            this.txt_firstaddress.TabIndex = 88;
            // 
            // txt_firstphone
            // 
            this.txt_firstphone.Location = new System.Drawing.Point(138, 497);
            this.txt_firstphone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_firstphone.Name = "txt_firstphone";
            this.txt_firstphone.Size = new System.Drawing.Size(174, 21);
            this.txt_firstphone.TabIndex = 87;
            // 
            // cmb_firstquery
            // 
            this.cmb_firstquery.FormattingEnabled = true;
            this.cmb_firstquery.Location = new System.Drawing.Point(432, 439);
            this.cmb_firstquery.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_firstquery.Name = "cmb_firstquery";
            this.cmb_firstquery.Size = new System.Drawing.Size(163, 20);
            this.cmb_firstquery.TabIndex = 86;
            // 
            // txt_firstman
            // 
            this.txt_firstman.Location = new System.Drawing.Point(138, 439);
            this.txt_firstman.Margin = new System.Windows.Forms.Padding(4);
            this.txt_firstman.Name = "txt_firstman";
            this.txt_firstman.Size = new System.Drawing.Size(174, 21);
            this.txt_firstman.TabIndex = 85;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(118, 385);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(550, 21);
            this.txt_email.TabIndex = 84;
            // 
            // txt_companyname
            // 
            this.txt_companyname.Location = new System.Drawing.Point(198, 329);
            this.txt_companyname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_companyname.Name = "txt_companyname";
            this.txt_companyname.Size = new System.Drawing.Size(196, 21);
            this.txt_companyname.TabIndex = 83;
            // 
            // txt_companyphone
            // 
            this.txt_companyphone.Location = new System.Drawing.Point(520, 330);
            this.txt_companyphone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_companyphone.Name = "txt_companyphone";
            this.txt_companyphone.Size = new System.Drawing.Size(148, 21);
            this.txt_companyphone.TabIndex = 82;
            // 
            // txt_homephone
            // 
            this.txt_homephone.Location = new System.Drawing.Point(520, 267);
            this.txt_homephone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_homephone.Name = "txt_homephone";
            this.txt_homephone.Size = new System.Drawing.Size(148, 21);
            this.txt_homephone.TabIndex = 81;
            // 
            // txt_cellphone
            // 
            this.txt_cellphone.Location = new System.Drawing.Point(520, 204);
            this.txt_cellphone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cellphone.Name = "txt_cellphone";
            this.txt_cellphone.Size = new System.Drawing.Size(148, 21);
            this.txt_cellphone.TabIndex = 80;
            // 
            // txt_homeaddress
            // 
            this.txt_homeaddress.Location = new System.Drawing.Point(198, 265);
            this.txt_homeaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txt_homeaddress.Name = "txt_homeaddress";
            this.txt_homeaddress.Size = new System.Drawing.Size(196, 21);
            this.txt_homeaddress.TabIndex = 79;
            // 
            // txt_celladdress
            // 
            this.txt_celladdress.Location = new System.Drawing.Point(198, 204);
            this.txt_celladdress.Margin = new System.Windows.Forms.Padding(4);
            this.txt_celladdress.Name = "txt_celladdress";
            this.txt_celladdress.Size = new System.Drawing.Size(198, 21);
            this.txt_celladdress.TabIndex = 78;
            // 
            // txt_sidno
            // 
            this.txt_sidno.Location = new System.Drawing.Point(432, 137);
            this.txt_sidno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sidno.Name = "txt_sidno";
            this.txt_sidno.Size = new System.Drawing.Size(236, 21);
            this.txt_sidno.TabIndex = 77;
            // 
            // cmb_sidtype
            // 
            this.cmb_sidtype.FormattingEnabled = true;
            this.cmb_sidtype.Location = new System.Drawing.Point(138, 135);
            this.cmb_sidtype.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_sidtype.Name = "cmb_sidtype";
            this.cmb_sidtype.Size = new System.Drawing.Size(180, 20);
            this.cmb_sidtype.TabIndex = 76;
            // 
            // dtp_recdate
            // 
            this.dtp_recdate.Location = new System.Drawing.Point(795, 71);
            this.dtp_recdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_recdate.Name = "dtp_recdate";
            this.dtp_recdate.Size = new System.Drawing.Size(170, 21);
            this.dtp_recdate.TabIndex = 75;
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Location = new System.Drawing.Point(513, 72);
            this.dtp_birthday.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(164, 21);
            this.dtp_birthday.TabIndex = 74;
            // 
            // cmb_sex
            // 
            this.cmb_sex.FormattingEnabled = true;
            this.cmb_sex.Location = new System.Drawing.Point(324, 72);
            this.cmb_sex.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.Size = new System.Drawing.Size(110, 20);
            this.cmb_sex.TabIndex = 73;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(344, 561);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 72;
            this.label23.Text = "透支额：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(50, 559);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 71;
            this.label22.Text = "余额：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(345, 498);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 70;
            this.label20.Text = "卡类型：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(688, 315);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 69;
            this.label19.Text = "手术史：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(688, 141);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 68;
            this.label18.Text = "过敏史：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 559);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 67;
            this.label17.Text = "联系地址：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 497);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 66;
            this.label16.Text = "联系电话：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(362, 439);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 65;
            this.label15.Text = "关系：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 439);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 64;
            this.label14.Text = "紧急联系人：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 389);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 63;
            this.label13.Text = "E_mail：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(414, 333);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 62;
            this.label12.Text = "联系电话：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 333);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 12);
            this.label11.TabIndex = 61;
            this.label11.Text = "公司名称及地址：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(414, 270);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 60;
            this.label10.Text = "联系电话：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 204);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 59;
            this.label9.Text = "家庭住址：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 209);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 58;
            this.label8.Text = "联系电话：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 265);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 57;
            this.label7.Text = "家庭住址（境外）：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 56;
            this.label6.Text = "证件类型：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 55;
            this.label5.Text = "证件号码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 54;
            this.label4.Text = "生日：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 53;
            this.label3.Text = "登记日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 52;
            this.label2.Text = "性别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 51;
            this.label1.Text = "姓名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_docoperate);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Location = new System.Drawing.Point(6, 53);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1028, 597);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            // 
            // btn_docoperate
            // 
            this.btn_docoperate.Location = new System.Drawing.Point(789, 72);
            this.btn_docoperate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_docoperate.Name = "btn_docoperate";
            this.btn_docoperate.Size = new System.Drawing.Size(166, 34);
            this.btn_docoperate.TabIndex = 0;
            this.btn_docoperate.Text = "保存过敏史手术史";
            this.btn_docoperate.UseVisualStyleBackColor = true;
            // 
            // Frm_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 665);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_operate);
            this.Controls.Add(this.txt_hispass);
            this.Controls.Add(this.cmb_cardtype);
            this.Controls.Add(this.txt_creditlimit);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.txt_firstaddress);
            this.Controls.Add(this.txt_firstphone);
            this.Controls.Add(this.cmb_firstquery);
            this.Controls.Add(this.txt_firstman);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_companyname);
            this.Controls.Add(this.txt_companyphone);
            this.Controls.Add(this.txt_homephone);
            this.Controls.Add(this.txt_cellphone);
            this.Controls.Add(this.txt_homeaddress);
            this.Controls.Add(this.txt_celladdress);
            this.Controls.Add(this.txt_sidno);
            this.Controls.Add(this.cmb_sidtype);
            this.Controls.Add(this.dtp_recdate);
            this.Controls.Add(this.dtp_birthday);
            this.Controls.Add(this.cmb_sex);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Frm_patient";
            this.Text = "患者登记";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmb_name;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_regno;
        private System.Windows.Forms.Button btn_appointment;
        private System.Windows.Forms.Button btn_modifypatient;
        private System.Windows.Forms.Button btn_addpatient;
        private System.Windows.Forms.TextBox txt_operate;
        private System.Windows.Forms.TextBox txt_hispass;
        private System.Windows.Forms.ComboBox cmb_cardtype;
        private System.Windows.Forms.TextBox txt_creditlimit;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.TextBox txt_firstaddress;
        private System.Windows.Forms.TextBox txt_firstphone;
        private System.Windows.Forms.ComboBox cmb_firstquery;
        private System.Windows.Forms.TextBox txt_firstman;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_companyname;
        private System.Windows.Forms.TextBox txt_companyphone;
        private System.Windows.Forms.TextBox txt_homephone;
        private System.Windows.Forms.TextBox txt_cellphone;
        private System.Windows.Forms.TextBox txt_homeaddress;
        private System.Windows.Forms.TextBox txt_celladdress;
        private System.Windows.Forms.TextBox txt_sidno;
        private System.Windows.Forms.ComboBox cmb_sidtype;
        private System.Windows.Forms.DateTimePicker dtp_recdate;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.ComboBox cmb_sex;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_docoperate;

    }
}