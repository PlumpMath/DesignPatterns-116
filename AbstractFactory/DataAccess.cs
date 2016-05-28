using System;

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
        //private static readonly string db = "SqlServer";
        private static readonly string db = "Access";

        public static IUser CreateUser()
        {
            IUser result = null;
            switch (db)
            {
                case "SqlServer":
                    result = new SqlserverUser();
                    break;
                case "Access":
                    result = new AccessUser();
                    break;
            }
            return result;
        }

        public static IDepartment CreateDepartment()
        {
            IDepartment result = null;
            switch (db)
            {
                case "SqlServer":
                    result = new SqlServerDepartment();
                    break;
                case "Access":
                    result = new AccessDepartment();
                    break;
            }
            return result;
        }
    }
}