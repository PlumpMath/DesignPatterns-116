using System;

namespace Proxy
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/23 7:17:10 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Subject说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public abstract class Subject
    {
        public abstract string Name { get; }
        public abstract void Request();
    }
}