using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WinForm
{
    public partial class FormGroupAdd : Form
    {
        public FormGroupAdd()
        {
            InitializeComponent();
        }

        private void FormGroupAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.ContactGroup model = new Model.ContactGroup();
            model.GroupName = txtGroupName.Text.Trim();
            model.Memo = txtGroupMemo.Text.Trim();
            BLL.ContactGroup bll = new BLL.ContactGroup();
            string msg;
            if(bll.Add(model,out msg))
            {
                MessageBox.Show("添加分组成功！");
            }
            else
            {
                MessageBox.Show(msg);
            }
        }
    }
}
