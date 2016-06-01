using System;

namespace Mediator
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/6/1 22:01:20 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Colleague说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}