using System;

namespace Mediator
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/6/1 22:00:29 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Mediator说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public abstract class Mediator
    {
        public abstract void Send(string message,Colleague colleague);
    }
}