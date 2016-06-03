using System;

namespace Visitor
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/6/4 6:28:19 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Visitor说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);
    }
}