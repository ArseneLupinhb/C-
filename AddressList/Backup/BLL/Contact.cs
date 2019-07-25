using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Common;
namespace BLL
{

    public class Contact
    {
        IDAL.IContact dal = DALFactory.DataAccess.CreateContact();
        public int GetContactCountByGroupId(int groupId)
        {
            return dal.GetContactCountByGroupId(groupId);
        }
        public DataTable GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        public bool CheckModel(Model.Contact model,out string message)
        {
            bool check = true;
            message = "";
            if (model.Name == "")
            {
                message="联系人姓名不能为空！";
                check = false;
                return check;
            }
            if (!Utility.CheckMobilePhone(model.Phone))
            {
                message="手机号码不正确！";
                check = false;
                return check;
            }
            if (!Utility.CheckEmail(model.Email))
            {
                message="Email格式不正确！！";
                check = false;
                return check;
            }
            if (!Utility.CheckQQ(model.QQ))
            {
                message="QQ号码不正确！";
                check = false;
                return check;
            }
            if (!Utility.CheckPhone(model.OfficePhone))
            {
                message="办公电话不正确！";
                check = false;
                return check;
            }
            if (!Utility.CheckPhone(model.HomePhone))
            {
                message="家庭电话不正确！";
                check = false;
                return check;
            }
            return check;
        }
        public bool Add(Model.Contact model,out string msg)
        {
             if(!CheckModel(model,out msg))
             {
                 return  false;
             }
             else
             {
                 return dal.Add(model);
             }
        }
        public bool Delete(int Id)
        {
            return dal.Delete(Id);
        }
        public bool Update(Model.Contact model,out string msg)
        {
            if(!CheckModel(model,out msg))
            {
                return false;
            }
            else
            {
                return dal.Update(model);
            }
        }
        public Model.Contact GetModel(int Id)
        {
            return dal.GetModel(Id);
        }

    }
}
