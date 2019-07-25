using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using IDAL;
namespace SQLDAL
{
	/// <summary>
	/// 数据访问类:User
	/// </summary>
	public partial class User:IUser
	{
		public User()
		{}
		#region  Method
        public bool Login(string userName,string userPassword)
        {
            StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [User]");
			strSql.Append(" where UserName=@UserName and Password=@UserPassword");
			SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
                    new SqlParameter("@UserPassword", SqlDbType.VarChar,50),};
			parameters[0].Value =userName;
            parameters[1].Value=userPassword;
            int n = Convert.ToInt32(SqlDbHelper.ExecuteScalar(strSql.ToString(),CommandType.Text,parameters));
            if (n == 1)
                return true;
            else
                return false;
        }
        public bool Update(Model.User model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [User] set ");
            strSql.Append("Password=@Password");
            strSql.Append(" where UserName=@UserName ");
            SqlParameter[] parameters = {
					new SqlParameter("@Password", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50)};
            parameters[0].Value = model.Password;
            parameters[1].Value = model.UserName;

            int rows = SqlDbHelper.ExecuteNonQuery(strSql.ToString(),CommandType.Text,parameters);
            if (rows==1)
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

