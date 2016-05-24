using System;

namespace Facade
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/25 7:41:49 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Light说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Light:Appliance
    {
        public Light(string name)
            : base(name)
        { }
    }
}