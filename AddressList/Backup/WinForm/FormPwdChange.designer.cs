namespace WinForm
{
    partial class FormPwdChange
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
            this.lbloldPwd = new System.Windows.Forms.Label();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.txtNewPwdAgain = new System.Windows.Forms.TextBox();
            this.lblNewPwdAgain = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbloldPwd
            // 
            this.lbloldPwd.AutoSize = true;
            this.lbloldPwd.Location = new System.Drawing.Point(25, 26);
            this.lbloldPwd.Name = "lbloldPwd";
            this.lbloldPwd.Size = new System.Drawing.Size(53, 12);
            this.lbloldPwd.TabIndex = 0;
            this.lbloldPwd.Text = "原始密码";
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(99, 26);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(109, 21);
            this.txtOldPwd.TabIndex = 1;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(99, 76);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(109, 21);
            this.txtNewPwd.TabIndex = 3;
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Location = new System.Drawing.Point(25, 78);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(41, 12);
            this.lblNewPwd.TabIndex = 2;
            this.lblNewPwd.Text = "新密码";
            // 
            // txtNewPwdAgain
            // 
            this.txtNewPwdAgain.Location = new System.Drawing.Point(99, 126);
            this.txtNewPwdAgain.Name = "txtNewPwdAgain";
            this.txtNewPwdAgain.PasswordChar = '*';
            this.txtNewPwdAgain.Size = new System.Drawing.Size(109, 21);
            this.txtNewPwdAgain.TabIndex = 5;
            // 
            // lblNewPwdAgain
            // 
            this.lblNewPwdAgain.AutoSize = true;
            this.lblNewPwdAgain.Location = new System.Drawing.Point(25, 130);
            this.lblNewPwdAgain.Name = "lblNewPwdAgain";
            this.lblNewPwdAgain.Size = new System.Drawing.Size(65, 12);
            this.lblNewPwdAgain.TabIndex = 4;
            this.lblNewPwdAgain.Text = "新密码确认";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(36, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(148, 182);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormPwdChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 226);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewPwdAgain);
            this.Controls.Add(this.lblNewPwdAgain);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.lblNewPwd);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.lbloldPwd);
            this.MaximizeBox = false;
            this.Name = "FormPwdChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloldPwd;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.TextBox txtNewPwdAgain;
        private System.Windows.Forms.Label lblNewPwdAgain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}