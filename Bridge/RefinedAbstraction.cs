using System;

namespace Bridge
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/31 7:24:16 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// RefinedAbstraction说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class RefinedAbstraction:Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}