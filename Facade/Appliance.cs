using System;

namespace Facade
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/25 7:38:52 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Appliance说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Appliance
    {
        private string name;

        protected Appliance(string name)
        {
            this.name = name;
        }

        public void On()
        {
            Console.WriteLine("打开了"+name);
        }

        public void Off()
        {
            Console.WriteLine("关闭了"+name);
        }
    }
}