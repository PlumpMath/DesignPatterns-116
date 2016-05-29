using System;

namespace Composite
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/30 7:11:10 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Component说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
}