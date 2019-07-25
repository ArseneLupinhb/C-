namespace BLL
{
    using System.Data;

    /// <summary>
    /// Defines the <see cref="ContactGroup" />
    /// </summary>
    public class ContactGroup
    {
        /// <summary>
        /// Defines the group
        /// </summary>
        internal IDAL.IContactGroup group = DALFactory.DataAccess.CreateContactGroup();

        /// <summary>
        /// The GetList
        /// </summary>
        /// <param name="strWhere">The strWhere<see cref="string"/></param>
        /// <returns>The <see cref="DataTable"/></returns>
        public DataTable GetList(string strWhere)
        {
            return group.GetList(strWhere);
        }

        /// <summary>
        /// The GetModel
        /// </summary>
        /// <param name="groupName">The groupName<see cref="string"/></param>
        /// <returns>The <see cref="Model.ContactGroup"/></returns>
        public Model.ContactGroup GetModel(string groupName)
        {
            return group.GetModel(groupName);
        }

        /// <summary>
        /// The GetModel
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="Model.ContactGroup"/></returns>
        public Model.ContactGroup GetModel(int id)
        {
            return group.GetModel(id);
        }

        /// <summary>
        /// The CheckModel
        /// </summary>
        /// <param name="model">The model<see cref="Model.ContactGroup"/></param>
        /// <param name="msg">The msg<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool CheckModel(Model.ContactGroup model, out string msg)
        {
            bool check = true;
            msg = "";
            if (model.GroupName == "")
            {
                msg = "分组名称不能为空";
                check = false;
            }
            return check;
        }

        /// <summary>
        /// The Add
        /// </summary>
        /// <param name="model">The model<see cref="Model.ContactGroup"/></param>
        /// <param name="msg">The msg<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool Add(Model.ContactGroup model, out string msg)
        {
            if (!CheckModel(model, out msg))
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
        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="Id">The Id<see cref="int"/></param>
        /// <returns>The <see cref="bool"/></returns>
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

        /// <summary>
        /// The Update
        /// </summary>
        /// <param name="model">The model<see cref="Model.ContactGroup"/></param>
        /// <param name="msg">The msg<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool Update(Model.ContactGroup model, out string msg)
        {
            if (!CheckModel(model, out msg))
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
