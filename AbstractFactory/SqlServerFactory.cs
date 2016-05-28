using System;

namespace AbstractFactory
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/28 10:32:53 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// SqlServerFactory说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class SqlServerFactory:IFactory
    {
        public IUser CreateUser()
        {
            return new SqlserverUser();
        }


        public IDepartment CreateDepartment()
        {
            return new SqlServerDepartment();
        }
    }
}