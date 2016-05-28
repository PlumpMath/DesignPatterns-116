using System;

namespace AbstractFactory
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/28 10:33:58 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// AccessFactory说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class AccessFactory:IFactory
    {
        public IUser CreateUser()
        {
            return new AccessUser();
        }


        public IDepartment CreateDepartment()
        {
            return new AccessDepartment();
        }
    }
}