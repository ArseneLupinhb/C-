namespace WinForm
{
    partial class FormContactAdd
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.txtOfficePhone = new System.Windows.Forms.TextBox();
            this.txtWorkUnit = new System.Windows.Forms.TextBox();
            this.txtQQ = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHomeAddress = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblMemo = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.lblOfficePhone = new System.Windows.Forms.Label();
            this.lblWorkUnit = new System.Windows.Forms.Label();
            this.lblQQ = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(325, 412);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(191, 412);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboGroup
            // 
            this.cboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(130, 260);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(147, 20);
            this.cboGroup.TabIndex = 44;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(130, 325);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(413, 67);
            this.txtMemo.TabIndex = 45;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(396, 158);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(147, 21);
            this.txtHomePhone.TabIndex = 41;
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Location = new System.Drawing.Point(130, 206);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(413, 21);
            this.txtHomeAddress.TabIndex = 42;
            // 
            // txtOfficePhone
            // 
            this.txtOfficePhone.Location = new System.Drawing.Point(130, 158);
            this.txtOfficePhone.Name = "txtOfficePhone";
            this.txtOfficePhone.Size = new System.Drawing.Size(147, 21);
            this.txtOfficePhone.TabIndex = 40;
            // 
            // txtWorkUnit
            // 
            this.txtWorkUnit.Location = new System.Drawing.Point(130, 102);
            this.txtWorkUnit.Name = "txtWorkUnit";
            this.txtWorkUnit.Size = new System.Drawing.Size(413, 21);
            this.txtWorkUnit.TabIndex = 39;
            // 
            // txtQQ
            // 
            this.txtQQ.Location = new System.Drawing.Point(130, 53);
            this.txtQQ.Name = "txtQQ";
            this.txtQQ.Size = new System.Drawing.Size(147, 21);
            this.txtQQ.TabIndex = 43;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(396, 53);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 21);
            this.txtEmail.TabIndex = 38;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(396, 12);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(147, 21);
            this.txtPhone.TabIndex = 37;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 21);
            this.txtName.TabIndex = 36;
            // 
            // lblHomeAddress
            // 
            this.lblHomeAddress.AutoSize = true;
            this.lblHomeAddress.Location = new System.Drawing.Point(43, 209);
            this.lblHomeAddress.Name = "lblHomeAddress";
            this.lblHomeAddress.Size = new System.Drawing.Size(53, 12);
            this.lblHomeAddress.TabIndex = 34;
            this.lblHomeAddress.Text = "家庭住址";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(43, 263);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(53, 12);
            this.lblGroup.TabIndex = 33;
            this.lblGroup.Text = "所在分组";
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(43, 344);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(29, 12);
            this.lblMemo.TabIndex = 32;
            this.lblMemo.Text = "备注";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(323, 161);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(53, 12);
            this.lblHomePhone.TabIndex = 31;
            this.lblHomePhone.Text = "家庭电话";
            // 
            // lblOfficePhone
            // 
            this.lblOfficePhone.AutoSize = true;
            this.lblOfficePhone.Location = new System.Drawing.Point(43, 161);
            this.lblOfficePhone.Name = "lblOfficePhone";
            this.lblOfficePhone.Size = new System.Drawing.Size(53, 12);
            this.lblOfficePhone.TabIndex = 30;
            this.lblOfficePhone.Text = "单位电话";
            // 
            // lblWorkUnit
            // 
            this.lblWorkUnit.AutoSize = true;
            this.lblWorkUnit.Location = new System.Drawing.Point(43, 102);
            this.lblWorkUnit.Name = "lblWorkUnit";
            this.lblWorkUnit.Size = new System.Drawing.Size(53, 12);
            this.lblWorkUnit.TabIndex = 29;
            this.lblWorkUnit.Text = "工作单位";
            // 
            // lblQQ
            // 
            this.lblQQ.AutoSize = true;
            this.lblQQ.Location = new System.Drawing.Point(43, 62);
            this.lblQQ.Name = "lblQQ";
            this.lblQQ.Size = new System.Drawing.Size(17, 12);
            this.lblQQ.TabIndex = 28;
            this.lblQQ.Text = "QQ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(323, 62);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 12);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "电子邮件";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(323, 15);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(29, 12);
            this.lblPhone.TabIndex = 26;
            this.lblPhone.Text = "手机";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "姓名";
            // 
            // FormContactAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 459);
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
            this.MaximizeBox = false;
            this.Name = "FormContactAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增联系人";
            this.Load += new System.EventHandler(this.FormContactAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.TextBox txtOfficePhone;
        private System.Windows.Forms.TextBox txtWorkUnit;
        private System.Windows.Forms.TextBox txtQQ;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHomeAddress;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label lblOfficePhone;
        private System.Windows.Forms.Label lblWorkUnit;
        private System.Windows.Forms.Label lblQQ;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
    }
}