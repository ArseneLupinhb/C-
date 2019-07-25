namespace WinForm
{
    partial class FormDB
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
            this.btnRestorePath = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.grpRestore = new System.Windows.Forms.GroupBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.lblRestore = new System.Windows.Forms.Label();
            this.sfdlgBackup = new System.Windows.Forms.SaveFileDialog();
            this.lblBackup = new System.Windows.Forms.Label();
            this.grpBackup = new System.Windows.Forms.GroupBox();
            this.btnBackupPath = new System.Windows.Forms.Button();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.ofdlgRestore = new System.Windows.Forms.OpenFileDialog();
            this.grpRestore.SuspendLayout();
            this.grpBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRestorePath
            // 
            this.btnRestorePath.Location = new System.Drawing.Point(368, 27);
            this.btnRestorePath.Name = "btnRestorePath";
            this.btnRestorePath.Size = new System.Drawing.Size(44, 21);
            this.btnRestorePath.TabIndex = 3;
            this.btnRestorePath.Text = "选择";
            this.btnRestorePath.UseVisualStyleBackColor = true;
            this.btnRestorePath.Click += new System.EventHandler(this.btnRestorePath_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(18, 68);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(383, 27);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "备份数据库";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // grpRestore
            // 
            this.grpRestore.Controls.Add(this.btnRestorePath);
            this.grpRestore.Controls.Add(this.btnRestore);
            this.grpRestore.Controls.Add(this.txtRestore);
            this.grpRestore.Controls.Add(this.lblRestore);
            this.grpRestore.Location = new System.Drawing.Point(12, 144);
            this.grpRestore.Name = "grpRestore";
            this.grpRestore.Size = new System.Drawing.Size(418, 114);
            this.grpRestore.TabIndex = 7;
            this.grpRestore.TabStop = false;
            this.grpRestore.Text = "恢复数据库";
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(18, 69);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(383, 27);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "恢复数据库";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txtRestore
            // 
            this.txtRestore.Location = new System.Drawing.Point(75, 27);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(287, 21);
            this.txtRestore.TabIndex = 2;
            // 
            // lblRestore
            // 
            this.lblRestore.AutoSize = true;
            this.lblRestore.Location = new System.Drawing.Point(16, 30);
            this.lblRestore.Name = "lblRestore";
            this.lblRestore.Size = new System.Drawing.Size(53, 12);
            this.lblRestore.TabIndex = 1;
            this.lblRestore.Text = "恢复路径";
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Location = new System.Drawing.Point(16, 30);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(53, 12);
            this.lblBackup.TabIndex = 1;
            this.lblBackup.Text = "备份路径";
            // 
            // grpBackup
            // 
            this.grpBackup.Controls.Add(this.btnBackupPath);
            this.grpBackup.Controls.Add(this.txtBackup);
            this.grpBackup.Controls.Add(this.lblBackup);
            this.grpBackup.Controls.Add(this.btnBackup);
            this.grpBackup.Location = new System.Drawing.Point(12, 12);
            this.grpBackup.Name = "grpBackup";
            this.grpBackup.Size = new System.Drawing.Size(418, 114);
            this.grpBackup.TabIndex = 6;
            this.grpBackup.TabStop = false;
            this.grpBackup.Text = "备份数据库";
            // 
            // btnBackupPath
            // 
            this.btnBackupPath.Location = new System.Drawing.Point(368, 27);
            this.btnBackupPath.Name = "btnBackupPath";
            this.btnBackupPath.Size = new System.Drawing.Size(44, 21);
            this.btnBackupPath.TabIndex = 3;
            this.btnBackupPath.Text = "选择";
            this.btnBackupPath.UseVisualStyleBackColor = true;
            this.btnBackupPath.Click += new System.EventHandler(this.btnBackupPath_Click);
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(75, 27);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Size = new System.Drawing.Size(287, 21);
            this.txtBackup.TabIndex = 2;
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 273);
            this.Controls.Add(this.grpRestore);
            this.Controls.Add(this.grpBackup);
            this.MaximizeBox = false;
            this.Name = "FormDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库备份与恢复";
            this.grpRestore.ResumeLayout(false);
            this.grpRestore.PerformLayout();
            this.grpBackup.ResumeLayout(false);
            this.grpBackup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestorePath;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.GroupBox grpRestore;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.Label lblRestore;
        private System.Windows.Forms.SaveFileDialog sfdlgBackup;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.GroupBox grpBackup;
        private System.Windows.Forms.Button btnBackupPath;
        private System.Windows.Forms.TextBox txtBackup;
        private System.Windows.Forms.OpenFileDialog ofdlgRestore;
    }
}