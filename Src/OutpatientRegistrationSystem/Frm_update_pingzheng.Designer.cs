namespace OutpatientRegistrationSystem
{
    partial class Frm_update_pingzheng
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
            this.btn_退出 = new System.Windows.Forms.Button();
            this.btn_保存 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_tips = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_退出
            // 
            this.btn_退出.Location = new System.Drawing.Point(584, 436);
            this.btn_退出.Name = "btn_退出";
            this.btn_退出.Size = new System.Drawing.Size(75, 23);
            this.btn_退出.TabIndex = 0;
            this.btn_退出.Text = "退出";
            this.btn_退出.UseVisualStyleBackColor = true;
            this.btn_退出.Click += new System.EventHandler(this.btn_退出_Click);
            // 
            // btn_保存
            // 
            this.btn_保存.Location = new System.Drawing.Point(498, 436);
            this.btn_保存.Name = "btn_保存";
            this.btn_保存.Size = new System.Drawing.Size(75, 23);
            this.btn_保存.TabIndex = 13;
            this.btn_保存.Text = "保存更改";
            this.btn_保存.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(697, 414);
            this.dataGridView1.TabIndex = 14;
            // 
            // lbl_tips
            // 
            this.lbl_tips.AutoSize = true;
            this.lbl_tips.Location = new System.Drawing.Point(13, 437);
            this.lbl_tips.Name = "lbl_tips";
            this.lbl_tips.Size = new System.Drawing.Size(401, 12);
            this.lbl_tips.TabIndex = 15;
            this.lbl_tips.Text = "tips：点击相应位置即可修改数据，delete可以删除，如需增加则另起一行";
            // 
            // Frm_update_pingzheng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 461);
            this.Controls.Add(this.lbl_tips);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_保存);
            this.Controls.Add(this.btn_退出);
            this.Name = "Frm_update_pingzheng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改病人凭证信息";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_退出;
        private System.Windows.Forms.Button btn_保存;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_tips;
    }
}