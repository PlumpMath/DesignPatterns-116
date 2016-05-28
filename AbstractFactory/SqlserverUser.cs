using System;

namespace AbstractFactory
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/28 11:23:53 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// SqlServerUser说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class SqlServerUser:IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在SQL Server中给User表增加了一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在SQL Server中根据ID得到User表一条记录");
            return null;
        }
    }
}