using System;

namespace Iterator
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/30 20:01:24 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Iterator说明：迭代器抽象类
    /// </summary> 
    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
}