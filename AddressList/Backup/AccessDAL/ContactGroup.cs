using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using IDAL;
namespace AccessDAL
{
	/// <summary>
	/// 数据访问类:ContactGroup
	/// </summary>
	public partial class ContactGroup:IContactGroup
	{
		public ContactGroup()
		{}
		#region  Method
        public DataTable GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,GroupName,Memo ");
            strSql.Append(" FROM ContactGroup ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return OleDbHelper.ExecuteDataTable(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.ContactGroup model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ContactGroup(");
            strSql.Append("GroupName,[Memo])");
            strSql.Append(" values(");
            strSql.Append("@GroupName,@Memo)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@GroupName", OleDbType.VarChar,50),
					new OleDbParameter("@Memo", OleDbType.VarChar,200)};
            parameters[0].Value = model.GroupName;
            parameters[1].Value = model.Memo;

            int rows = OleDbHelper.ExecuteNonQuery(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Model.ContactGroup GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,GroupName,Memo from ContactGroup ");
            strSql.Append(" where Id=@Id");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.Integer,4)
};
            parameters[0].Value = Id;

            Model.ContactGroup model = new Model.ContactGroup();
            DataTable dt = OleDbHelper.ExecuteDataTable(strSql.ToString(),parameters);
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
        public Model.ContactGroup GetModel(string groupName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,GroupName,Memo from ContactGroup ");
            strSql.Append(" where GroupName=@GroupName");
            OleDbParameter[] parameters = {
					new OleDbParameter("@GroupName", OleDbType.VarChar,50)
};
            parameters[0].Value =groupName;

            Model.ContactGroup model = new Model.ContactGroup();
            DataTable dt = OleDbHelper.ExecuteDataTable(strSql.ToString(), parameters);
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

        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ContactGroup ");
            strSql.Append(" where Id=@Id");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.Integer,4)
};
            parameters[0].Value = Id;

            int rows = OleDbHelper.ExecuteNonQuery(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(Model.ContactGroup model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ContactGroup set ");
            strSql.Append("GroupName=@GroupName,");
            strSql.Append("[Memo]=@Memo");
            strSql.Append(" where Id=@Id");
            OleDbParameter[] parameters = {
					new OleDbParameter("@GroupName", OleDbType.VarChar,50),
					new OleDbParameter("@Memo", OleDbType.VarChar,200),
					new OleDbParameter("@Id", OleDbType.Integer,4)};
            parameters[0].Value = model.GroupName;
            parameters[1].Value = model.Memo;
            parameters[2].Value = model.Id;

            int rows = OleDbHelper.ExecuteNonQuery(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
		#endregion  Method
	}
}

