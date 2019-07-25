using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Configuration;
using IDAL;
namespace DALFactory
{
    sealed public class DataAccess
    {
        private static readonly string AssemblyName = ConfigurationManager.AppSettings["DAL"];
        public static IUser CreateUser()
        {
            string className = AssemblyName + ".User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IContact CreateContact()
        {
            string className = AssemblyName + ".Contact";
            return (IContact)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IContactGroup CreateContactGroup()
        {
            string className = AssemblyName + ".ContactGroup";
            return (IContactGroup)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IBackupAndRestoreDb CreateBackupAndRestoreDb()
        {
            string className = AssemblyName + ".BackupAndRestoreDb";
            return (IBackupAndRestoreDb)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
