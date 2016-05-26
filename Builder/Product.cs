using System;
using System.Collections.Generic;

namespace Builder
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/26 22:23:38 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Product说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Product
    {
        List<string> parts = new List<string>();

        public void Add(string part)
        {
            if (parts.Contains(part))
                return;
            else
                parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\n 产品 创建 ---");
            for (int i = 0; i < parts.Count; ++i)
                Console.WriteLine(parts[i]);
        }
    }
}