namespace SQLDAL
{
    using IDAL;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;

    /// <summary>
    /// 数据访问类:ContactGroup
    /// </summary>
    public partial class ContactGroup : IContactGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactGroup"/> class.
        /// </summary>
        public ContactGroup()
        {
        }

        /// <summary>
        /// The GetList
        /// </summary>
        /// <param name="strWhere">The strWhere<see cref="string"/></param>
        /// <returns>The <see cref="DataTable"/></returns>
        public DataTable GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,GroupName,Memo ");
            strSql.Append(" FROM ContactGroup ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SqlDbHelper.ExecuteDataTable(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model">The model<see cref="Model.ContactGroup"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool Add(Model.ContactGroup model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ContactGroup(");
            strSql.Append("GroupName,Memo)");
            strSql.Append(" values (");
            strSql.Append("@GroupName,@Memo)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@GroupName", SqlDbType.NVarChar,50),
                    new SqlParameter("@Memo", SqlDbType.NVarChar,200)};
            parameters[0].Value = model.GroupName;
            parameters[1].Value = model.Memo;

            int rows = SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The GetModel
        /// </summary>
        /// <param name="Id">The Id<see cref="int"/></param>
        /// <returns>The <see cref="Model.ContactGroup"/></returns>
        public Model.ContactGroup GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,GroupName,Memo from ContactGroup ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.Int,4)
};
            parameters[0].Value = Id;

            Model.ContactGroup model = new Model.ContactGroup();
            DataTable dt = SqlDbHelper.ExecuteDataTable(strSql.ToString(), CommandType.Text, parameters);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Id"] != null && dt.Rows[0]["Id"].ToString() != "")
                {
                    model.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                }
                if (dt.Rows[0]["GroupName"] != null && dt.Rows[0]["GroupName"].ToString() != "")
                {
                    model.GroupName = dt.Rows[0]["GroupName"].ToString();
                }
                if (dt.Rows[0]["Memo"] != null && dt.Rows[0]["Memo"].ToString() != "")
                {
                    model.Memo = dt.Rows[0]["Memo"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// The GetModel
        /// </summary>
        /// <param name="groupName">The groupName<see cref="string"/></param>
        /// <returns>The <see cref="Model.ContactGroup"/></returns>
        public Model.ContactGroup GetModel(string groupName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,GroupName,Memo from ContactGroup ");
            strSql.Append(" where GroupName=@GroupName");
            SqlParameter[] parameters = {
                    new SqlParameter("@GroupName", SqlDbType.NVarChar,50)
};
            parameters[0].Value = groupName;

            Model.ContactGroup model = new Model.ContactGroup();
            DataTable dt = SqlDbHelper.ExecuteDataTable(strSql.ToString(), CommandType.Text, parameters);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Id"] != null && dt.Rows[0]["Id"].ToString() != "")
                {
                    model.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                }
                if (dt.Rows[0]["GroupName"] != null && dt.Rows[0]["GroupName"].ToString() != "")
                {
                    model.GroupName = dt.Rows[0]["GroupName"].ToString();
                }
                if (dt.Rows[0]["Memo"] != null && dt.Rows[0]["Memo"].ToString() != "")
                {
                    model.Memo = dt.Rows[0]["Memo"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="Id">The Id<see cref="int"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ContactGroup ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.Int,4)
};
            parameters[0].Value = Id;

            int rows = SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The Update
        /// </summary>
        /// <param name="model">The model<see cref="Model.ContactGroup"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool Update(Model.ContactGroup model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ContactGroup set ");
            strSql.Append("GroupName=@GroupName,");
            strSql.Append("Memo=@Memo");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
                    new SqlParameter("@GroupName", SqlDbType.NVarChar,50),
                    new SqlParameter("@Memo", SqlDbType.NVarChar,200),
                    new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.GroupName;
            parameters[1].Value = model.Memo;
            parameters[2].Value = model.Id;

            int rows = SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
