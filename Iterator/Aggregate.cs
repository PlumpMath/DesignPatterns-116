using System;

namespace Iterator
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/30 20:03:19 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Aggregate说明：聚集抽象类 
    /// </summary> 
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}