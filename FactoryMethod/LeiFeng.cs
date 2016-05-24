using System;

namespace FactoryMethod
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/23 20:39:09 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// LeiFeng说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class LeiFeng
    {
        public void Sweep()
        {
            Console.WriteLine("扫地");
        }

        public void Wash()
        {
            Console.WriteLine("洗衣");
        }

        public void Cook()
        {
            Console.WriteLine("做饭");
        }
    }
}