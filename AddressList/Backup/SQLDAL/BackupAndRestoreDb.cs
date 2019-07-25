using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using IDAL;
namespace SQLDAL
{
    public class BackupAndRestoreDb:IBackupAndRestoreDb
    {
        public void BackDb(string backupPath)
        {
            if (File.Exists(backupPath))
            {
                File.Delete(backupPath);
            }
            string strSql = "backup database AddressList to disk=@backupPath";
            SqlParameter[] parameters = {
                    new SqlParameter("@backupPath", SqlDbType.NVarChar,200)
                    };
            parameters[0].Value = backupPath;
            SqlDbHelper.ExecuteNonQuery(strSql, CommandType.Text, parameters);
        }
        public void RestoreDb(string restorePath)
        {
            string strSql = "Alter Database AddressList Set Offline with Rollback immediate;use master;restore database AddressList from disk=@restorePath With Replace;Alter Database AddressList Set OnLine With rollback Immediate";
            SqlParameter[] parameters = {
                    new SqlParameter("@restorePath", SqlDbType.NVarChar,200)  
                    };
            parameters[0].Value = restorePath;
            SqlDbHelper.ExecuteNonQuery(strSql, CommandType.Text, parameters);
        }
    }
}
