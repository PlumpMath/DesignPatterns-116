using System;

namespace Bridge
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/31 7:22:21 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Abstraction说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public abstract class Abstraction
    {
        protected Implementor implementor;

        public void SetImplementor(Implementor implementor)
        {
            this.implementor = implementor;
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}