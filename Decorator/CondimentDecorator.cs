using System;

namespace Decorator
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/21 23:00:21 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// CondimentDecorator说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public abstract class CondimentDecorator:Beverage
    {
        private Beverage beverage;

        public CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription();
        }

        public override double Cost()
        {
            return beverage.Cost();
        }
    }
}