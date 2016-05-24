using System;

namespace FactoryMethod
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/23 21:08:19 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// VolunteerFactory说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class VolunteerFactory:IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Volunteer();
        }
    }
}