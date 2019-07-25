namespace WinForm
{
    partial class FormContactDetail
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblQQ = new System.Windows.Forms.Label();
            this.lblWorkUnit = new System.Windows.Forms.Label();
            this.lblOfficePhone = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.lblMemo = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblHomeAddress = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtQQ = new System.Windows.Forms.TextBox();
            this.txtWorkUnit = new System.Windows.Forms.TextBox();
            this.txtOfficePhone = new System.Windows.Forms.TextBox();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(36, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(53, 12);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "自动编号";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(316, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "姓名";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(36, 70);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(29, 12);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "手机";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(316, 76);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 12);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "电子邮件";
            // 
            // lblQQ
            // 
            this.lblQQ.AutoSize = true;
            this.lblQQ.Location = new System.Drawing.Point(36, 305);
            this.lblQQ.Name = "lblQQ";
            this.lblQQ.Size = new System.Drawing.Size(17, 12);
            this.lblQQ.TabIndex = 4;
            this.lblQQ.Text = "QQ";
            // 
            // lblWorkUnit
            // 
            this.lblWorkUnit.AutoSize = true;
            this.lblWorkUnit.Location = new System.Drawing.Point(36, 124);
            this.lblWorkUnit.Name = "lblWorkUnit";
            this.lblWorkUnit.Size = new System.Drawing.Size(53, 12);
            this.lblWorkUnit.TabIndex = 5;
            this.lblWorkUnit.Text = "工作单位";
            // 
            // lblOfficePhone
            // 
            this.lblOfficePhone.AutoSize = true;
            this.lblOfficePhone.Location = new System.Drawing.Point(36, 183);
            this.lblOfficePhone.Name = "lblOfficePhone";
            this.lblOfficePhone.Size = new System.Drawing.Size(53, 12);
            this.lblOfficePhone.TabIndex = 6;
            this.lblOfficePhone.Text = "单位电话";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(316, 183);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(53, 12);
            this.lblHomePhone.TabIndex = 7;
            this.lblHomePhone.Text = "家庭电话";
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(36, 366);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(29, 12);
            this.lblMemo.TabIndex = 8;
            this.lblMemo.Text = "备注";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(316, 299);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(53, 12);
            this.lblGroup.TabIndex = 9;
            this.lblGroup.Text = "所在分组";
            // 
            // lblHomeAddress
            // 
            this.lblHomeAddress.AutoSize = true;
            this.lblHomeAddress.Location = new System.Drawing.Point(36, 231);
            this.lblHomeAddress.Name = "lblHomeAddress";
            this.lblHomeAddress.Size = new System.Drawing.Size(53, 12);
            this.lblHomeAddress.TabIndex = 10;
            this.lblHomeAddress.Text = "家庭住址";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(123, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(147, 21);
            this.txtId.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(389, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 21);
            this.txtName.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(123, 67);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(147, 21);
            this.txtPhone.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(389, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 21);
            this.txtEmail.TabIndex = 14;
            // 
            // txtQQ
            // 
            this.txtQQ.Location = new System.Drawing.Point(123, 296);
            this.txtQQ.Name = "txtQQ";
            this.txtQQ.Size = new System.Drawing.Size(147, 21);
            this.txtQQ.TabIndex = 19;
            // 
            // txtWorkUnit
            // 
            this.txtWorkUnit.Location = new System.Drawing.Point(123, 124);
            this.txtWorkUnit.Name = "txtWorkUnit";
            this.txtWorkUnit.Size = new System.Drawing.Size(413, 21);
            this.txtWorkUnit.TabIndex = 15;
            // 
            // txtOfficePhone
            // 
            this.txtOfficePhone.Location = new System.Drawing.Point(123, 180);
            this.txtOfficePhone.Name = "txtOfficePhone";
            this.txtOfficePhone.Size = new System.Drawing.Size(147, 21);
            this.txtOfficePhone.TabIndex = 16;
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Location = new System.Drawing.Point(123, 228);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(413, 21);
            this.txtHomeAddress.TabIndex = 18;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(389, 180);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(147, 21);
            this.txtHomePhone.TabIndex = 17;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(123, 347);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(413, 67);
            this.txtMemo.TabIndex = 21;
            // 
            // cboGroup
            // 
            this.cboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(389, 296);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(147, 20);
            this.cboGroup.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(185, 451);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(318, 451);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormContactDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 498);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboGroup);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.txtHomePhone);
            this.Controls.Add(this.txtHomeAddress);
            this.Controls.Add(this.txtOfficePhone);
            this.Controls.Add(this.txtWorkUnit);
            this.Controls.Add(this.txtQQ);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblHomeAddress);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblMemo);
            this.Controls.Add(this.lblHomePhone);
            this.Controls.Add(this.lblOfficePhone);
            this.Controls.Add(this.lblWorkUnit);
            this.Controls.Add(this.lblQQ);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.MaximizeBox = false;
            this.Name = "FormContactDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "联系人详细信息";
            this.Load += new System.EventHandler(this.FormContactDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblQQ;
        private System.Windows.Forms.Label lblWorkUnit;
        private System.Windows.Forms.Label lblOfficePhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblHomeAddress;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtQQ;
        private System.Windows.Forms.TextBox txtWorkUnit;
        private System.Windows.Forms.TextBox txtOfficePhone;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}

