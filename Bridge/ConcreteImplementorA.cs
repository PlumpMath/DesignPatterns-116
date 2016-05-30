using System;

namespace Bridge
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/31 7:20:35 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// ConcreteImplementorA说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class ConcreteImplementorA:Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现A的方法执行");
        }
    }
}