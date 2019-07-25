using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace BLL
{
    public class ContactGroup
    {
        IDAL.IContactGroup group = DALFactory.DataAccess.CreateContactGroup();
        public DataTable GetList(string strWhere)
        {
            return group.GetList(strWhere);
        }
        public Model.ContactGroup GetModel(string groupName)
        {
            return group.GetModel(groupName);
        }
        public Model.ContactGroup GetModel(int id)
        {
            return group.GetModel(id);
        }
        public bool CheckModel(Model.ContactGroup model,out string msg)
        {
            bool check=true;
            msg="";
            if (model.GroupName == "")
            {
                msg = "分组名称不能为空";
                check = false;
            }
            return check;
        }
        public bool Add(Model.ContactGroup model,out string msg)
        {
            if(!CheckModel(model,out msg))
            {  
                return false;
            }
            else
            {
                //业务逻辑，判断分组名称是否同数据库中已有的重复
                Model.ContactGroup modelCheck = GetModel(model.GroupName);
                if (modelCheck != null)
                {
                    msg = "分组名称重复";
                    return false;
                }
                else
                {
                    return group.Add(model);
                }
            }
        }

        //删除
        public bool Delete(int Id)
        {
            IDAL.IContact contact = DALFactory.DataAccess.CreateContact();
            int count = contact.GetContactCountByGroupId(Id);
            if (count > 0)
            {
                return false;//该分组下存在联系人，不允许删除分组
            }
            else
            {
                return group.Delete(Id);
            }           
        }

        public bool Update(Model.ContactGroup model,out string msg)
        {
            if(!CheckModel(model,out msg))
            {
                return false;
            }
            else
            {
                return group.Update(model);
            }
        }
    }
}
