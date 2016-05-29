using System;

namespace Composite
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/30 7:13:28 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Leaf说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }
    }
}