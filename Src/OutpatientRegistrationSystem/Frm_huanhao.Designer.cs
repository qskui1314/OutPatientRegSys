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
            this.SuspendLayout();
            // 
            // lb_kahao
            // 
            this.lb_kahao.AutoSize = true;
            this.lb_kahao.Location = new System.Drawing.Point(12, 9);
            this.lb_kahao.Name = "lb_kahao";
            this.lb_kahao.Size = new System.Drawing.Size(29, 12);
            this.lb_kahao.TabIndex = 0;
            this.lb_kahao.Text = "卡号";
            // 
            // tb_kahao
            // 
            this.tb_kahao.Location = new System.Drawing.Point(84, 7);
            this.tb_kahao.Name = "tb_kahao";
            this.tb_kahao.Size = new System.Drawing.Size(206, 21);
            this.tb_kahao.TabIndex = 1;
            // 
            // lb_binglihao
            // 
            this.lb_binglihao.AutoSize = true;
            this.lb_binglihao.Location = new System.Drawing.Point(423, 9);
            this.lb_binglihao.Name = "lb_binglihao";
            this.lb_binglihao.Size = new System.Drawing.Size(41, 12);
            this.lb_binglihao.TabIndex = 2;
            this.lb_binglihao.Text = "病历号";
            // 
            // tb_binglihao
            // 
            this.tb_binglihao.Location = new System.Drawing.Point(483, 7);
            this.tb_binglihao.Name = "tb_binglihao";
            this.tb_binglihao.Size = new System.Drawing.Size(204, 21);
            this.tb_binglihao.TabIndex = 3;
            // 
            // bt_chaxun
            // 
            this.bt_chaxun.Location = new System.Drawing.Point(325, 4);
            this.bt_chaxun.Name = "bt_chaxun";
            this.bt_chaxun.Size = new System.Drawing.Size(75, 23);
            this.bt_chaxun.TabIndex = 4;
            this.bt_chaxun.Text = "查询";
            this.bt_chaxun.UseVisualStyleBackColor = true;
            // 
            // bt_tuichu
            // 
            this.bt_tuichu.Location = new System.Drawing.Point(579, 403);
            this.bt_tuichu.Name = "bt_tuichu";
            this.bt_tuichu.Size = new System.Drawing.Size(75, 23);
            this.bt_tuichu.TabIndex = 5;
            this.bt_tuichu.Text = "退出";
            this.bt_tuichu.UseVisualStyleBackColor = true;
            this.bt_tuichu.Click += new System.EventHandler(this.bt_tuichu_Click);
            // 
            // Frm_huanhao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 461);
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
    }
}