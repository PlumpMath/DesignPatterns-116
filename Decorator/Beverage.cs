using System;

namespace Decorator
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/21 22:56:57 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Beverage说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}