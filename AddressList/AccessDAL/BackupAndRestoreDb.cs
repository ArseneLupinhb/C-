using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using IDAL;
namespace AccessDAL
{
    public class BackupAndRestoreDb : IBackupAndRestoreDb
    {
        public void BackDb(string backupPath)
        {
            if (File.Exists(backupPath))
            {
                File.Delete(backupPath);
            }
            File.Copy(System.Configuration.ConfigurationManager.AppSettings["DbPath"], backupPath, true);
        }
        public void RestoreDb(string restorePath)
        {
            File.Copy(restorePath, System.Configuration.ConfigurationManager.AppSettings["DbPath"], true);
        }
    }
}
