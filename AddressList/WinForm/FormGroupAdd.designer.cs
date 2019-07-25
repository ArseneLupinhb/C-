namespace WinForm
{
    partial class FormGroupAdd
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
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.txtGroupMemo = new System.Windows.Forms.TextBox();
            this.lblGroupMemo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(174, 208);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(32, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(30, 34);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(53, 12);
            this.lblGroupName.TabIndex = 50;
            this.lblGroupName.Text = "分组名称";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(89, 31);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(160, 21);
            this.txtGroupName.TabIndex = 51;
            // 
            // txtGroupMemo
            // 
            this.txtGroupMemo.Location = new System.Drawing.Point(89, 96);
            this.txtGroupMemo.Multiline = true;
            this.txtGroupMemo.Name = "txtGroupMemo";
            this.txtGroupMemo.Size = new System.Drawing.Size(160, 76);
            this.txtGroupMemo.TabIndex = 53;
            // 
            // lblGroupMemo
            // 
            this.lblGroupMemo.AutoSize = true;
            this.lblGroupMemo.Location = new System.Drawing.Point(30, 99);
            this.lblGroupMemo.Name = "lblGroupMemo";
            this.lblGroupMemo.Size = new System.Drawing.Size(29, 12);
            this.lblGroupMemo.TabIndex = 52;
            this.lblGroupMemo.Text = "备注";
            // 
            // FormGroupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.txtGroupMemo);
            this.Controls.Add(this.lblGroupMemo);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.Name = "FormGroupAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加分组";
            this.Load += new System.EventHandler(this.FormGroupAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.TextBox txtGroupMemo;
        private System.Windows.Forms.Label lblGroupMemo;
    }
}