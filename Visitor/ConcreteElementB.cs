using System;

namespace Visitor
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/6/4 6:31:52 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// ConcreteElementB说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class ConcreteElementB:Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public void OperationB()
        { }
    }
}