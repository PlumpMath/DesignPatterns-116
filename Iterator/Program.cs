﻿using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();

            a[0] = "大鸟";
            a[1] = "小菜";
            a[2] = "行李";
            a[3] = "老外";
            a[4] = "公交内部员工";
            a[5] = "小偷";

            Iterator iterator = new ConcreteIterator(a);

            object item = iterator.First();

            while (!iterator.IsDone())
            {
                Console.WriteLine("{0}请买车票！",iterator.CurrentItem());
                iterator.Next();
            }
        }
    }
}
