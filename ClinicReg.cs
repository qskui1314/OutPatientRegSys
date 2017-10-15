using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ҽԺ����ϵͳ
{
	/// <summary>
	/// ClinicReg ��ժҪ˵����
	/// </summary>
	public class ClinicReg : System.Windows.Forms.Form
	{
		private string regID,infoID;//��������Һű�źͲ�����Ϣ����
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
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
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

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
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
            this.txt5.Text = "����";
            this.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt6
            // 
            this.txt6.Enabled = false;
            this.txt6.Location = new System.Drawing.Point(104, 472);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(100, 21);
            this.txt6.TabIndex = 0;
            this.txt6.Text = "ѡ��";
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
            this.txt7.Text = "�Զ�";
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
            this.groupBox1.Text = "�Һ���Ϣ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(72, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "��������";
            // 
            // cmb1
            // 
            this.cmb1.Items.AddRange(new object[] {
            "��",
            "Ů"});
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
            this.label1.Text = "����";
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
            this.label2.Text = "�Ա�";
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
            this.label3.Text = "����";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(336, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "����";
            // 
            // cmb2
            // 
            this.cmb2.Items.AddRange(new object[] {
            "����",
            "����",
            "�ɹ���",
            "����",
            "����",
            "ά�����",
            "��������"});
            this.cmb2.Location = new System.Drawing.Point(520, 61);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(104, 20);
            this.cmb2.TabIndex = 3;
            // 
            // cmb3
            // 
            this.cmb3.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmb3.Items.AddRange(new object[] {
            "�Է�",
            "����",
            "����"});
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
            this.label6.Text = "�Һ�����";
            // 
            // cmb4
            // 
            this.cmb4.Items.AddRange(new object[] {
            "��ͨ",
            "ר�Һ�20Ԫ",
            "ר�Һ�5Ԫ"});
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
            this.label7.Text = "�Һſ���";
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
            this.label8.Text = "ҽ��";
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
            this.label9.Text = "�Һŷ���";
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
            this.label10.Text = "�Һ�ʱ��";
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
            this.tBtnNew.Text = "����";
            this.tBtnNew.ToolTipText = "����";
            // 
            // tBtnSubmit
            // 
            this.tBtnSubmit.ImageIndex = 7;
            this.tBtnSubmit.Name = "tBtnSubmit";
            this.tBtnSubmit.Text = "����";
            this.tBtnSubmit.ToolTipText = "����";
            // 
            // tBtnCancel
            // 
            this.tBtnCancel.ImageIndex = 8;
            this.tBtnCancel.Name = "tBtnCancel";
            this.tBtnCancel.Text = "ȡ��";
            this.tBtnCancel.ToolTipText = "ȡ��";
            // 
            // tBtnQuit
            // 
            this.tBtnQuit.ImageIndex = 9;
            this.tBtnQuit.Name = "tBtnQuit";
            this.tBtnQuit.Text = "�˳�";
            this.tBtnQuit.ToolTipText = "�˳�";
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
            this.Text = "������Һš�";
            this.Load += new System.EventHandler(this.ClinicReg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		//-----------��������ʱ���������б����Ŀ---------------
		private void ClinicReg_Load(object sender, System.EventArgs e)
		{
			//���á��������ϡ������б�������ѡ��
			string strConn="workstation id=localhost;Integrated Security=SSPI;database=hisbook;";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmb=cn.CreateCommand();
			cmb.CommandText="select distinct ���� from ��������";
			SqlDataReader dr=cmb.ExecuteReader();
			cmb5.Items.Clear();
			while(dr.Read())
			{
				cmb5.Items.Add(dr.GetValue(0).ToString().Trim());
			}
			dr.Close();		
		}

		//--------------���������ƴ���------------------
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if(e.Button.ToolTipText=="����")
			{
				this.SetDefaultValue();//����Ĭ��ֵ
				//�����±��
				this.regID=this.CreateNewID("select max(���) ����� from ����Һ�");
				this.infoID=this.CreateNewID("select max(���) ����� from ������Ϣ��");				
			}
			if(e.Button.ToolTipText=="����")
			{
				if(this.CheckNotNull()==false)
				{
					return;
				}
				this.SaveReg();
				this.clearInfo();

			}
			if(e.Button.ToolTipText=="ȡ��")
			{
				this.clearInfo();
				
			}
			if(e.Button.ToolTipText=="�˳�")
			{
				this.Close();
			}
		}

		//-------------����ѡ��Ŀ�����ʾҽ���嵥------------
		private void cmb6_DropDown(object sender, System.EventArgs e)
		{
			//���á�ҽ���������б�������ѡ��
			cmb6.Items.Clear();//���ԭ������ѡ��
			if(cmb5.Text.Trim()=="")
			{
				return;
			}
			string strConn="workstation id=localhost;Integrated Security=SSPI;database=hisbook;";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmb=cn.CreateCommand();
			cmb.CommandText="select distinct ���� from ҽ������ where ����='"+cmb5.Text.Trim()+"'";
			SqlDataReader dr=cmb.ExecuteReader();			
			while(dr.Read())
			{
				cmb6.Items.Add(dr.GetValue(0).ToString().Trim());
			}
			dr.Close();		
		}

		//-----------�������е���Ϣ------------
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
		//-----------��������ʱ����Ĭ����Ϣ------------
		private void SetDefaultValue()
		{
			cmb1.SelectedText="��";//Ĭ���Ա�Ϊ����
			cmb2.SelectedText="����";//Ĭ������Ϊ����
			cmb3.SelectedText="�Է�";//Ĭ�Ϸ�������Ϊ�Է�
			cmb4.SelectedText="��ͨ";//Ĭ�ϹҺ�����Ϊ��ͨ
			cmb5.SelectedText="�ڿ�";//Ĭ�ϹҺſ���Ϊ�ڿ�
			txt3.Text="1";//Ĭ�ϹҺŷ�1Ԫ
			txt4.Text=System.DateTime.Now.ToString();//��ǰϵͳʱ��Ϊ�Һ�ʱ��			
		}

		//----------���ݹҺ��������ùҺŷ���-----------
		private void cmb4_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			if(cmb4.SelectedIndex==0)//��ͨ��1Ԫ
			{
				txt3.Text="1";
			}
			if(cmb4.SelectedIndex==1)//20Ԫר�Һ�
			{
				txt3.Text="20";
			}
			if(cmb4.SelectedIndex==2)//5Ԫר�Һ�
			{
				txt3.Text="5";
			}
		
		}
		
		//---------------���ǿ��ֶ�--------------
		private bool CheckNotNull()
		{
			if(txt1.Text.Trim()=="")
			{
				MessageBox.Show("������������Ϊ��,����������","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(cmb3.Text.Trim()=="")
			{
				MessageBox.Show("�������Ͳ���Ϊ��,��ѡ���������","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(cmb5.Text.Trim()=="")
			{
				MessageBox.Show("�Һſ��Ҳ���Ϊ��,��ѡ��Һſ���","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(cmb6.Text.Trim()=="")
			{
				MessageBox.Show("δѡ��ҽ������ѡ��ĹҺſ���û��ҽ��","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			return(true);
		}
		//-----------����Һ���Ϣ�Ͳ�����Ϣ-------------
		private void SaveReg()
		{
			string strConn="workstation id=localhost;Integrated Security=SSPI;database=hisbook;";
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmb=cn.CreateCommand();
			
			string insertStr="insert into ������Ϣ��([���], [����], [�Ա�], [����], [����], [��������]) "
				+"values('"+infoID+"','"+txt1.Text.Trim()+"','"+cmb1.Text.Trim()+"','"+txt2.Text.Trim()
				+"','"+cmb2.Text.Trim()+"','"+cmb3.Text.Trim()+"')";			
			cmb.CommandText=insertStr;
			try
			{
				cmb.ExecuteNonQuery();
			}
			catch(Exception express)
			{
				MessageBox.Show(express.ToString(),"����������Ϣ����",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			insertStr="insert into ����Һ�([���], [���˱��], [����], [�Ա�], [�Һſ���], [��������],"
                +"[�Һ�����], [�Һŷ���], [ҽ��], [ʱ��], [�Ƿ��ѻ���]) "
				+"values('"+regID+"','"+infoID+"','"+txt1.Text.Trim()+"','"+cmb1.Text.Trim()+"','"
				+cmb5.Text.Trim()+"','"+cmb3.Text.Trim()+"','"+cmb4.Text.Trim()+"',CAST('"+txt3.Text
				+"' as decimal),'"+cmb6.Text.Trim()+"','"+txt4.Text+"','��')";
			cmb.CommandText=insertStr;
			try
			{
				cmb.ExecuteNonQuery();
			}
			catch(Exception express)
			{
				MessageBox.Show(express.ToString(),"��������ҺŴ���",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}


		}
		
		//---------��������Ϣʱ������sql�����㲢�����µ�����Һű�źͲ�����Ϣ---------
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
				return(System.DateTime.Now.Year.ToString()+"0000001");//��������Ϊ���+7λ���
			}
			result=result.Substring(4,7);
			int newID=Convert.ToInt32(result)+1;
			int length=newID.ToString().Length;
			string returnStr=System.DateTime.Now.Year.ToString();
			switch(length)//�����µı���
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
