using System;

namespace Adapter
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/28 20:47:51 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Target说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求！");
        }
    }
}