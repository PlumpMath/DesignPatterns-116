using System;

namespace Decorator
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/21 23:07:18 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Mocha说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
            : base(beverage)
        { }

        public override string GetDescription()
        {
            return base.GetDescription() + "+ Mocha";
        }

        public override double Cost()
        {
            return base.Cost() + 0.20;
        }
    }
}