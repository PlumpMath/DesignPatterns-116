using System;

namespace Adapter
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/28 20:49:48 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Adapter说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Adapter:Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecialRequest();
        }
    }
}