namespace SQLDAL
{
    using IDAL;
    using System.Data;
    using System.Data.SqlClient;
    using System.IO;

    /// <summary>
    /// Defines the <see cref="BackupAndRestoreDb" />
    /// </summary>
    public class BackupAndRestoreDb : IBackupAndRestoreDb
    {
        /// <summary>
        /// The BackDb
        /// </summary>
        /// <param name="backupPath">The backupPath<see cref="string"/></param>
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

        /// <summary>
        /// The RestoreDb
        /// </summary>
        /// <param name="restorePath">The restorePath<see cref="string"/></param>
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
