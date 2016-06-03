using System;

namespace Visitor
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/6/4 6:29:39 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Element说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}