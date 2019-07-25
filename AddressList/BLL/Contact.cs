namespace BLL
{
    using Common;
    using System.Data;

    /// <summary>
    /// Defines the <see cref="Contact" />
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Defines the dal
        /// </summary>
        internal IDAL.IContact dal = DALFactory.DataAccess.CreateContact();

        /// <summary>
        /// The GetContactCountByGroupId
        /// </summary>
        /// <param name="groupId">The groupId<see cref="int"/></param>
        /// <returns>The <see cref="int"/></returns>
        public int GetContactCountByGroupId(int groupId)
        {
            return dal.GetContactCountByGroupId(groupId);
        }

        /// <summary>
        /// The GetList
        /// </summary>
        /// <param name="strWhere">The strWhere<see cref="string"/></param>
        /// <returns>The <see cref="DataTable"/></returns>
        public DataTable GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        /// The CheckModel
        /// </summary>
        /// <param name="model">The model<see cref="Model.Contact"/></param>
        /// <param name="message">The message<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool CheckModel(Model.Contact model, out string message)
        {
            bool check = true;
            message = "";
            if (model.Name == "")
            {
                message = "联系人姓名不能为空！";
                check = false;
                return check;
            }
            if (!Utility.CheckMobilePhone(model.Phone))
            {
                message = "手机号码不正确！";
                check = false;
                return check;
            }
            if (!Utility.CheckEmail(model.Email))
            {
                message = "Email格式不正确！！";
                check = false;
                return check;
            }
            if (!Utility.CheckQQ(model.QQ))
            {
                message = "QQ号码不正确！";
                check = false;
                return check;
            }
            if (!Utility.CheckPhone(model.OfficePhone))
            {
                message = "办公电话不正确！";
                check = false;
                return check;
            }
            if (!Utility.CheckPhone(model.HomePhone))
            {
                message = "家庭电话不正确！";
                check = false;
                return check;
            }
            return check;
        }

        /// <summary>
        /// The Add
        /// </summary>
        /// <param name="model">The model<see cref="Model.Contact"/></param>
        /// <param name="msg">The msg<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool Add(Model.Contact model, out string msg)
        {
            if (!CheckModel(model, out msg))
            {
                return false;
            }
            else
            {
                return dal.Add(model);
            }
        }

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="Id">The Id<see cref="int"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool Delete(int Id)
        {
            return dal.Delete(Id);
        }

        /// <summary>
        /// The Update
        /// </summary>
        /// <param name="model">The model<see cref="Model.Contact"/></param>
        /// <param name="msg">The msg<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool Update(Model.Contact model, out string msg)
        {
            if (!CheckModel(model, out msg))
            {
                return false;
            }
            else
            {
                return dal.Update(model);
            }
        }

        /// <summary>
        /// The GetModel
        /// </summary>
        /// <param name="Id">The Id<see cref="int"/></param>
        /// <returns>The <see cref="Model.Contact"/></returns>
        public Model.Contact GetModel(int Id)
        {
            return dal.GetModel(Id);
        }
    }
}
