namespace SQLDAL
{
    using IDAL;
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;

    /// <summary>
    /// 数据访问类:User
    /// </summary>
    public partial class User : IUser
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
        }

        /// <summary>
        /// The Login
        /// </summary>
        /// <param name="userName">The userName<see cref="string"/></param>
        /// <param name="userPassword">The userPassword<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool Login(string userName, string userPassword)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [User]");
            strSql.Append(" where UserName=@UserName and Password=@UserPassword");
            SqlParameter[] parameters = {
                    new SqlParameter("@UserName", SqlDbType.VarChar,50),
                    new SqlParameter("@UserPassword", SqlDbType.VarChar,50),};
            parameters[0].Value = userName;
            parameters[1].Value = userPassword;
            int n = Convert.ToInt32(SqlDbHelper.ExecuteScalar(strSql.ToString(), CommandType.Text, parameters));
            if (n == 1)
                return true;
            else
                return false;
        }

        /// <summary>
        /// The Update
        /// </summary>
        /// <param name="model">The model<see cref="Model.User"/></param>
        /// <returns>The <see cref="bool"/></returns>
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

            int rows = SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
            if (rows == 1)
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
