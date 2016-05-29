using System;
using System.Collections.Generic;

namespace Composite
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/30 7:15:49 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Composite说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name)
            : base(name)
        {
        }

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            foreach (Component component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}