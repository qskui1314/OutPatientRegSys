using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace 医院管理系统
{
	/// <summary>
	/// ClinicReg 的摘要说明。
	/// </summary>
	public class ClinicReg : System.Windows.Forms.Form
	{
		private string regID,infoID;//保存门诊挂号编号和病人信息库编号
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmb1;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmb2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmb3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmb4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmb5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmb6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ImageList imageList1;
		protected System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton tBtnNew;
		private System.Windows.Forms.ToolBarButton tBtnSubmit;
		private System.Windows.Forms.ToolBarButton tBtnCancel;
		private System.Windows.Forms.ToolBarButton tBtnQuit;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt4;
		private System.Windows.Forms.TextBox txt5;
		private System.Windows.Forms.TextBox txt6;
		private System.Windows.Forms.TextBox txt7;
		private System.Windows.Forms.TextBox txt8;
		private System.ComponentModel.IContainer components;

		public ClinicReg()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.cmb3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb5 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb6 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.tBtnNew = new System.Windows.Forms.ToolBarButton();
            this.tBtnSubmit = new System.Windows.Forms.ToolBarButton();
            this.tBtnCancel = new System.Windows.Forms.ToolBarButton();
            this.tBtnQuit = new System.Windows.Forms.ToolBarButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt5
            // 
            this.txt5.BackColor = System.Drawing.SystemColors.Desktop;
            this.txt5.Enabled = false;
            this.txt5.Location = new System.Drawing.Point(0, 472);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(100, 21);
            this.txt5.TabIndex = 0;
            this.txt5.Text = "必填";
            this.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt6
            // 
            this.txt6.Enabled = false;
            this.txt6.Location = new System.Drawing.Point(104, 472);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(100, 21);
            this.txt6.TabIndex = 0;
            this.txt6.Text = "选填";
            this.txt6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt7
            // 
            this.txt7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt7.Enabled = false;
            this.txt7.Location = new System.Drawing.Point(208, 472);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(100, 21);
            this.txt7.TabIndex = 0;
            this.txt7.Text = "自动";
            this.txt7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt8
            // 
            this.txt8.BackColor = System.Drawing.SystemColors.Control;
            this.txt8.Enabled = false;
            this.txt8.Location = new System.Drawing.Point(312, 472);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(368, 21);
            this.txt8.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb1);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb2);
            this.groupBox1.Controls.Add(this.cmb3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmb4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmb5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmb6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Controls.Add(this.txt4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 432);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "挂号信息";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(72, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "费用类型";
            // 
            // cmb1
            // 
            this.cmb1.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmb1.Location = new System.Drawing.Point(208, 61);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(104, 20);
            this.cmb1.TabIndex = 3;
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.Desktop;
            this.txt1.Location = new System.Drawing.Point(56, 61);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 21);
            this.txt1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(8, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 8);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(8, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 8);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(176, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(368, 61);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 21);
            this.txt2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(488, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "民族";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(336, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "年龄";
            // 
            // cmb2
            // 
            this.cmb2.Items.AddRange(new object[] {
            "汉族",
            "满族",
            "蒙古族",
            "回族",
            "藏族",
            "维吾尔族",
            "哈萨克族"});
            this.cmb2.Location = new System.Drawing.Point(520, 61);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(104, 20);
            this.cmb2.TabIndex = 3;
            // 
            // cmb3
            // 
            this.cmb3.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmb3.Items.AddRange(new object[] {
            "自费",
            "公费",
            "离休"});
            this.cmb3.Location = new System.Drawing.Point(128, 160);
            this.cmb3.Name = "cmb3";
            this.cmb3.Size = new System.Drawing.Size(136, 20);
            this.cmb3.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(328, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "挂号类型";
            // 
            // cmb4
            // 
            this.cmb4.Items.AddRange(new object[] {
            "普通",
            "专家号20元",
            "专家号5元"});
            this.cmb4.Location = new System.Drawing.Point(384, 160);
            this.cmb4.Name = "cmb4";
            this.cmb4.Size = new System.Drawing.Size(144, 20);
            this.cmb4.TabIndex = 3;
            this.cmb4.SelectionChangeCommitted += new System.EventHandler(this.cmb4_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(72, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "挂号科室";
            // 
            // cmb5
            // 
            this.cmb5.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmb5.Location = new System.Drawing.Point(128, 216);
            this.cmb5.Name = "cmb5";
            this.cmb5.Size = new System.Drawing.Size(136, 20);
            this.cmb5.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(328, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "医生";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb6
            // 
            this.cmb6.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmb6.Location = new System.Drawing.Point(384, 216);
            this.cmb6.Name = "cmb6";
            this.cmb6.Size = new System.Drawing.Size(144, 20);
            this.cmb6.TabIndex = 3;
            this.cmb6.DropDown += new System.EventHandler(this.cmb6_DropDown);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(128, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "挂号费用";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(128, 344);
            this.txt3.Name = "txt3";
            this.txt3.ReadOnly = true;
            this.txt3.Size = new System.Drawing.Size(136, 21);
            this.txt3.TabIndex = 2;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(384, 344);
            this.txt4.Name = "txt4";
            this.txt4.ReadOnly = true;
            this.txt4.Size = new System.Drawing.Size(144, 21);
            this.txt4.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(384, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "挂号时间";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // toolBar1
            // 
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tBtnNew,
            this.tBtnSubmit,
            this.tBtnCancel,
            this.tBtnQuit});
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(680, 41);
            this.toolBar1.TabIndex = 30;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // tBtnNew
            // 
            this.tBtnNew.ImageIndex = 4;
            this.tBtnNew.Name = "tBtnNew";
            this.tBtnNew.Text = "新增";
            this.tBtnNew.ToolTipText = "新增";
            // 
            // tBtnSubmit
            // 
            this.tBtnSubmit.ImageIndex = 7;
            this.tBtnSubmit.Name = "tBtnSubmit";
            this.tBtnSubmit.Text = "保存";
            this.tBtnSubmit.ToolTipText = "保存";
            // 
            // tBtnCancel
            // 
            this.tBtnCancel.ImageIndex = 8;
            this.tBtnCancel.Name = "tBtnCancel";
            this.tBtnCancel.Text = "取消";
            this.tBtnCancel.ToolTipText = "取消";
            // 
            // tBtnQuit
            // 
            this.tBtnQuit.ImageIndex = 9;
            this.tBtnQuit.Name = "tBtnQuit";
            this.tBtnQuit.Text = "退出";
            this.tBtnQuit.ToolTipText = "退出";
            // 
            // ClinicReg
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(680, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.txt8);
            this.Controls.Add(this.toolBar1);
            this.Name = "ClinicReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【门诊挂号】";
            this.Load += new System.EventHandler(this.ClinicReg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		//-----------创建窗体时设置下拉列表框项目---------------
		private void ClinicReg_Load(object sender, System.EventArgs e)
		{
			//设置【科室资料】下拉列表框的下拉选项
			string strConn="workstation id=localhost;Integrated Security=SSPI;database=hisbook;";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmb=cn.CreateCommand();
			cmb.CommandText="select distinct 名称 from 科室资料";
			SqlDataReader dr=cmb.ExecuteReader();
			cmb5.Items.Clear();
			while(dr.Read())
			{
				cmb5.Items.Add(dr.GetValue(0).ToString().Trim());
			}
			dr.Close();		
		}

		//--------------工具栏控制代码------------------
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if(e.Button.ToolTipText=="新增")
			{
				this.SetDefaultValue();//设置默认值
				//生成新编号
				this.regID=this.CreateNewID("select max(编号) 最大编号 from 门诊挂号");
				this.infoID=this.CreateNewID("select max(编号) 最大编号 from 病人信息库");				
			}
			if(e.Button.ToolTipText=="保存")
			{
				if(this.CheckNotNull()==false)
				{
					return;
				}
				this.SaveReg();
				this.clearInfo();

			}
			if(e.Button.ToolTipText=="取消")
			{
				this.clearInfo();
				
			}
			if(e.Button.ToolTipText=="退出")
			{
				this.Close();
			}
		}

		//-------------根据选择的科室显示医生清单------------
		private void cmb6_DropDown(object sender, System.EventArgs e)
		{
			//设置【医生】下拉列表框的下拉选项
			cmb6.Items.Clear();//清空原有下拉选项
			if(cmb5.Text.Trim()=="")
			{
				return;
			}
			string strConn="workstation id=localhost;Integrated Security=SSPI;database=hisbook;";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmb=cn.CreateCommand();
			cmb.CommandText="select distinct 姓名 from 医生资料 where 科室='"+cmb5.Text.Trim()+"'";
			SqlDataReader dr=cmb.ExecuteReader();			
			while(dr.Read())
			{
				cmb6.Items.Add(dr.GetValue(0).ToString().Trim());
			}
			dr.Close();		
		}

		//-----------清空面板中的信息------------
		private void clearInfo()
		{
			txt1.Clear();
			txt2.Clear();
			txt3.Clear();
			txt4.Clear();
			cmb1.Text="";
			cmb2.Text="";
			cmb3.Text="";
			cmb4.Text="";
			cmb5.Text="";
			cmb6.Text="";
		}
		//-----------新增病人时设置默认信息------------
		private void SetDefaultValue()
		{
			cmb1.SelectedText="男";//默认性别为男性
			cmb2.SelectedText="汉族";//默认民族为汉族
			cmb3.SelectedText="自费";//默认费用类型为自费
			cmb4.SelectedText="普通";//默认挂号类型为普通
			cmb5.SelectedText="内科";//默认挂号科室为内科
			txt3.Text="1";//默认挂号费1元
			txt4.Text=System.DateTime.Now.ToString();//当前系统时间为挂号时间			
		}

		//----------根据挂号类型设置挂号费用-----------
		private void cmb4_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			if(cmb4.SelectedIndex==0)//普通号1元
			{
				txt3.Text="1";
			}
			if(cmb4.SelectedIndex==1)//20元专家号
			{
				txt3.Text="20";
			}
			if(cmb4.SelectedIndex==2)//5元专家号
			{
				txt3.Text="5";
			}
		
		}
		
		//---------------检查非空字段--------------
		private bool CheckNotNull()
		{
			if(txt1.Text.Trim()=="")
			{
				MessageBox.Show("病人姓名不能为空,请输入姓名","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(cmb3.Text.Trim()=="")
			{
				MessageBox.Show("费用类型不能为空,请选择费用类型","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(cmb5.Text.Trim()=="")
			{
				MessageBox.Show("挂号科室不能为空,请选择挂号科室","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(cmb6.Text.Trim()=="")
			{
				MessageBox.Show("未选择医生或您选择的挂号科室没有医生","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			return(true);
		}
		//-----------保存挂号信息和病人信息-------------
		private void SaveReg()
		{
			string strConn="workstation id=localhost;Integrated Security=SSPI;database=hisbook;";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmb=cn.CreateCommand();
			
			string insertStr="insert into 病人信息库([编号], [姓名], [性别], [年龄], [民族], [费用类型]) "
				+"values('"+infoID+"','"+txt1.Text.Trim()+"','"+cmb1.Text.Trim()+"','"+txt2.Text.Trim()
				+"','"+cmb2.Text.Trim()+"','"+cmb3.Text.Trim()+"')";			
			cmb.CommandText=insertStr;
			try
			{
				cmb.ExecuteNonQuery();
			}
			catch(Exception express)
			{
				MessageBox.Show(express.ToString(),"新增病人信息错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			insertStr="insert into 门诊挂号([编号], [病人编号], [姓名], [性别], [挂号科室], [费用类型],"
                +"[挂号类型], [挂号费用], [医生], [时间], [是否已划价]) "
				+"values('"+regID+"','"+infoID+"','"+txt1.Text.Trim()+"','"+cmb1.Text.Trim()+"','"
				+cmb5.Text.Trim()+"','"+cmb3.Text.Trim()+"','"+cmb4.Text.Trim()+"',CAST('"+txt3.Text
				+"' as decimal),'"+cmb6.Text.Trim()+"','"+txt4.Text+"','否')";
			cmb.CommandText=insertStr;
			try
			{
				cmb.ExecuteNonQuery();
			}
			catch(Exception express)
			{
				MessageBox.Show(express.ToString(),"新增门诊挂号错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}


		}
		
		//---------在新增信息时，根据sql语句计算并设置新的门诊挂号编号和病人信息---------
		private string CreateNewID(string sql)
		{
			string strConn="workstation id=localhost;Integrated Security=SSPI;database=hisbook;";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmb=cn.CreateCommand();
			cmb.CommandText=sql;
			string result;
			if(cmb.ExecuteScalar()!=System.DBNull.Value)
			{
				result=cmb.ExecuteScalar().ToString().Trim();
			}
			else
			{
				return(System.DateTime.Now.Year.ToString()+"0000001");//命名规则为年份+7位编号
			}
			result=result.Substring(4,7);
			int newID=Convert.ToInt32(result)+1;
			int length=newID.ToString().Length;
			string returnStr=System.DateTime.Now.Year.ToString();
			switch(length)//生成新的编码
			{
				case 1:
					returnStr+="000000"+newID.ToString();					
					break;
				case 2:
					returnStr+="00000"+newID.ToString();					
					break;
				case 3:
					returnStr+="0000"+newID.ToString();					
					break;
				case 4:
					returnStr+="000"+newID.ToString();					
					break;
				case 5:
					returnStr+="00"+newID.ToString();					
					break;
				case 6:
					returnStr+="0"+newID.ToString();					
					break;
				case 7:
					returnStr+=newID.ToString();					
					break;
			}
			return(returnStr);
		}
	}
}
