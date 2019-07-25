using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
namespace AccessDAL
{
    /// <summary>
    /// 针对Access数据库操作的通用类
    /// Version:1.0
    /// </summary>
    public class OleDbHelper
    {
        //private static string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        private static string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ConfigurationManager.AppSettings["DbPath"];
        /// <summary>
        /// 设置数据库连接字符串
        /// </summary>
        public static string ConnectionString
        {
            get { return connString; }
            set { connString = value; }
        }

        /// <summary>
        /// 执行一个查询,并返回查询结果
        /// </summary>
        /// <param name="commandText">要执行的SQL语句</param>
        /// <param name="parameters">Transact-SQL 语句的参数数组</param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string commandText, OleDbParameter[] parameters)
        {
            DataTable data = new DataTable();//实例化DataTable，用于装载查询结果集
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                using (OleDbCommand command = new OleDbCommand(commandText, connection))
                {
                    //如果同时传入了参数，则添加这些参数
                    if (parameters != null)
                    {
                        foreach (OleDbParameter parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }
                    //通过包含查询SQL的OleDbCommand实例来实例化OleDbDataAdapter
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    adapter.Fill(data);//填充DataTable
                }
            }
            return data;
        }
        public static DataTable ExecuteDataTable(string commandText)
        {
            return ExecuteDataTable(commandText, null);
        }



        /// <summary>
        /// 将 CommandText 发送到 Connection 并生成一个 OleDbDataReader。
        /// </summary>
        /// <param name="commandText">要执行的SQL语句</param>
        /// <param name="parameters">Transact-SQL 语句的参数数组</param>
        /// <returns></returns>
        public static OleDbDataReader ExecuteReader(string commandText, OleDbParameter[] parameters)
        {
            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand(commandText, connection);
            //如果同时传入了参数，则添加这些参数
            if (parameters != null)
            {
                foreach (OleDbParameter parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }
            }
            connection.Open();
            //CommandBehavior.CloseConnection参数指示关闭Reader对象时关闭与其关联的Connection对象
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
        /// <summary>
        /// 将 CommandText 发送到 Connection 并生成一个 OleDbDataReader。
        /// </summary>
        /// <param name="commandText">要执行的查询SQL文本命令</param>
        /// <returns></returns>
        public static OleDbDataReader ExecuteReader(string commandText)
        {
            return ExecuteReader(commandText, null);
        }


        /// <summary>
        /// 从数据库中检索单个值（例如一个聚合值）。
        /// </summary>
        /// <param name="commandText">要执行的SQL语句</param>
        /// <param name="parameters">Transact-SQL 语句的参数数组</param>
        /// <returns></returns>
        public static Object ExecuteScalar(string commandText, OleDbParameter[] parameters)
        {
            object result = null;
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                using (OleDbCommand command = new OleDbCommand(commandText, connection))
                {
                    //如果同时传入了参数，则添加这些参数
                    if (parameters != null)
                    {
                        foreach (OleDbParameter parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }
                    connection.Open();//打开数据库连接
                    result = command.ExecuteScalar();
                }
            }
            return result;//返回查询结果的第一行第一列，忽略其它行和列
        }
        /// <summary>
        /// 从数据库中检索单个值（例如一个聚合值）。
        /// </summary>
        /// <param name="commandText">要执行的查询SQL文本命令</param>
        /// <returns></returns>
        public static Object ExecuteScalar(string commandText)
        {
            return ExecuteScalar(commandText,null);
        }


        /// <summary>
        /// 对数据库执行增删改操作
        /// </summary>
        /// <param name="commandText">要执行的SQL语句</param>
        /// <param name="parameters">Transact-SQL 语句的参数数组</param>
        /// <returns>返回执行操作受影响的行数</returns>
        public static int ExecuteNonQuery(string commandText, OleDbParameter[] parameters)
        {
            int count = 0;
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                using (OleDbCommand command = new OleDbCommand(commandText, connection))
                {
                    //如果同时传入了参数，则添加这些参数
                    if (parameters != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            command.Parameters.Add(parameters[i]);
                        }
                        //foreach (OleDbParameter parameter in parameters)
                        //{
                        //    command.Parameters.Add(parameter);
                        //}
                    }
                    connection.Open();//打开数据库连接
                    count = command.ExecuteNonQuery();
                }
            }
            return count;//返回执行增删改操作之后，数据库中受影响的行数
        }
        /// <summary>
        /// 对数据库执行增删改操作
        /// </summary>
        /// <param name="commandText">要执行的查询SQL文本命令</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string commandText)
        {
            return ExecuteNonQuery(commandText, null);
        }
    }
}
