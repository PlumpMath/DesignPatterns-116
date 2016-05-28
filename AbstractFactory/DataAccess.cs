using System;
using System.Reflection;
using System.Configuration;

namespace AbstractFactory
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/28 10:52:18 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// DataAccess说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class DataAccess
    {
        private static readonly string AssemblyName = "AbstractFactory";
        //private static readonly string db = "SqlServer";
        private static readonly string db = ConfigurationManager.AppSettings["DB"];

        public static IUser CreateUser()
        {
            string className = AssemblyName + "." + db + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartment CreateDepartment()
        {
            string className = AssemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}