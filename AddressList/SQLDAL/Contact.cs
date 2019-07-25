namespace SQLDAL
{
    using IDAL;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;

    /// <summary>
    /// 数据访问类:Contact
    /// </summary>
    public class Contact : IContact
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// The GetContactCountByGroupId
        /// </summary>
        /// <param name="groupId">The groupId<see cref="int"/></param>
        /// <returns>The <see cref="int"/></returns>
        public int GetContactCountByGroupId(int groupId)
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("select count(1) from Contact");
            buffer.Append(" where GroupId=@GroupId");
            SqlParameter[] parameters = {
                    new SqlParameter("@GroupId", SqlDbType.Int,4)
                    };
            parameters[0].Value = groupId;
            return int.Parse(SqlDbHelper.ExecuteScalar(buffer.ToString(), CommandType.Text, parameters).ToString());
        }

        /// <summary>
        /// The GetList
        /// </summary>
        /// <param name="strWhere">The strWhere<see cref="string"/></param>
        /// <returns>The <see cref="DataTable"/></returns>
        public DataTable GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Contact.Id,Name,Phone,Email,QQ,GroupName from Contact,ContactGroup where Contact.GroupId=ContactGroup.Id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            strSql.Append(" order by Contact.Id desc");
            return SqlDbHelper.ExecuteDataTable(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model">The model<see cref="Model.Contact"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool Add(Model.Contact model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Contact(");
            strSql.Append("Name,Phone,Email,QQ,WorkUnit,OfficePhone,HomeAddress,HomePhone,Memo,GroupId)");
            strSql.Append(" values (");
            strSql.Append("@Name,@Phone,@Email,@QQ,@WorkUnit,@OfficePhone,@HomeAddress,@HomePhone,@Memo,@GroupId)");
            SqlParameter[] parameters = {
                    new SqlParameter("@Name", SqlDbType.NVarChar,50),
                    new SqlParameter("@Phone", SqlDbType.VarChar,11),
                    new SqlParameter("@Email", SqlDbType.NVarChar,50),
                    new SqlParameter("@QQ", SqlDbType.VarChar,20),
                    new SqlParameter("@WorkUnit", SqlDbType.NVarChar,200),
                    new SqlParameter("@OfficePhone", SqlDbType.VarChar,20),
                    new SqlParameter("@HomeAddress", SqlDbType.NVarChar,200),
                    new SqlParameter("@HomePhone", SqlDbType.VarChar,20),
                    new SqlParameter("@Memo", SqlDbType.NVarChar,200),
                    new SqlParameter("@GroupId", SqlDbType.Int,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Phone;
            parameters[2].Value = model.Email;
            parameters[3].Value = model.QQ;
            parameters[4].Value = model.WorkUnit;
            parameters[5].Value = model.OfficePhone;
            parameters[6].Value = model.HomeAddress;
            parameters[7].Value = model.HomePhone;
            parameters[8].Value = model.Memo;
            parameters[9].Value = model.GroupId;

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
        /// The Delete
        /// </summary>
        /// <param name="Id">The Id<see cref="int"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Contact ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.Int,4)};
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
        /// <param name="model">The model<see cref="Model.Contact"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool Update(Model.Contact model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Contact set ");
            strSql.Append("Name=@Name,");
            strSql.Append("Phone=@Phone,");
            strSql.Append("Email=@Email,");
            strSql.Append("QQ=@QQ,");
            strSql.Append("WorkUnit=@WorkUnit,");
            strSql.Append("OfficePhone=@OfficePhone,");
            strSql.Append("HomeAddress=@HomeAddress,");
            strSql.Append("HomePhone=@HomePhone,");
            strSql.Append("Memo=@Memo,");
            strSql.Append("GroupId=@GroupId");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
                    new SqlParameter("@Name", SqlDbType.NVarChar,50),
                    new SqlParameter("@Phone", SqlDbType.VarChar,11),
                    new SqlParameter("@Email", SqlDbType.NVarChar,50),
                    new SqlParameter("@QQ", SqlDbType.VarChar,20),
                    new SqlParameter("@WorkUnit", SqlDbType.NVarChar,200),
                    new SqlParameter("@OfficePhone", SqlDbType.VarChar,20),
                    new SqlParameter("@HomeAddress", SqlDbType.NVarChar,200),
                    new SqlParameter("@HomePhone", SqlDbType.VarChar,20),
                    new SqlParameter("@Memo", SqlDbType.NVarChar,200),
                    new SqlParameter("@GroupId", SqlDbType.Int,4),
                    new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Phone;
            parameters[2].Value = model.Email;
            parameters[3].Value = model.QQ;
            parameters[4].Value = model.WorkUnit;
            parameters[5].Value = model.OfficePhone;
            parameters[6].Value = model.HomeAddress;
            parameters[7].Value = model.HomePhone;
            parameters[8].Value = model.Memo;
            parameters[9].Value = model.GroupId;
            parameters[10].Value = model.Id;

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
        /// <returns>The <see cref="Model.Contact"/></returns>
        public Model.Contact GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,Name,Phone,Email,QQ,WorkUnit,OfficePhone,HomeAddress,HomePhone,Memo,GroupId from Contact ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.Int,4)
};
            parameters[0].Value = Id;

            Model.Contact model = new Model.Contact();
            DataTable dt = SqlDbHelper.ExecuteDataTable(strSql.ToString(), CommandType.Text, parameters);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Id"] != null && dt.Rows[0]["Id"].ToString() != "")
                {
                    model.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                }
                if (dt.Rows[0]["Name"] != null && dt.Rows[0]["Name"].ToString() != "")
                {
                    model.Name = dt.Rows[0]["Name"].ToString();
                }
                if (dt.Rows[0]["Phone"] != null && dt.Rows[0]["Phone"].ToString() != "")
                {
                    model.Phone = dt.Rows[0]["Phone"].ToString();
                }
                if (dt.Rows[0]["Email"] != null && dt.Rows[0]["Email"].ToString() != "")
                {
                    model.Email = dt.Rows[0]["Email"].ToString();
                }
                if (dt.Rows[0]["QQ"] != null && dt.Rows[0]["QQ"].ToString() != "")
                {
                    model.QQ = dt.Rows[0]["QQ"].ToString();
                }
                if (dt.Rows[0]["WorkUnit"] != null && dt.Rows[0]["WorkUnit"].ToString() != "")
                {
                    model.WorkUnit = dt.Rows[0]["WorkUnit"].ToString();
                }
                if (dt.Rows[0]["OfficePhone"] != null && dt.Rows[0]["OfficePhone"].ToString() != "")
                {
                    model.OfficePhone = dt.Rows[0]["OfficePhone"].ToString();
                }
                if (dt.Rows[0]["HomeAddress"] != null && dt.Rows[0]["HomeAddress"].ToString() != "")
                {
                    model.HomeAddress = dt.Rows[0]["HomeAddress"].ToString();
                }
                if (dt.Rows[0]["HomePhone"] != null && dt.Rows[0]["HomePhone"].ToString() != "")
                {
                    model.HomePhone = dt.Rows[0]["HomePhone"].ToString();
                }
                if (dt.Rows[0]["Memo"] != null && dt.Rows[0]["Memo"].ToString() != "")
                {
                    model.Memo = dt.Rows[0]["Memo"].ToString();
                }
                if (dt.Rows[0]["GroupId"] != null && dt.Rows[0]["GroupId"].ToString() != "")
                {
                    model.GroupId = int.Parse(dt.Rows[0]["GroupId"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }
    }
}
