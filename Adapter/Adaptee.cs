using System;

namespace Adapter
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/28 20:48:50 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Adaptee说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Adaptee
    {
        public void SpecialRequest()
        {
            Console.WriteLine("特殊请求！");
        }
    }
}