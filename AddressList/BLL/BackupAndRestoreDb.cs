namespace BLL
{
    /// <summary>
    /// Defines the <see cref="BackupAndRestoreDb" />
    /// </summary>
    public class BackupAndRestoreDb
    {
        /// <summary>
        /// Defines the dal
        /// </summary>
        internal IDAL.IBackupAndRestoreDb dal = DALFactory.DataAccess.CreateBackupAndRestoreDb();

        /// <summary>
        /// The BackDb
        /// </summary>
        /// <param name="backupPath">The backupPath<see cref="string"/></param>
        public void BackDb(string backupPath)
        {
            dal.BackDb(backupPath);
        }

        /// <summary>
        /// The RestoreDb
        /// </summary>
        /// <param name="restorePath">The restorePath<see cref="string"/></param>
        public void RestoreDb(string restorePath)
        {
            dal.RestoreDb(restorePath);
        }
    }
}
