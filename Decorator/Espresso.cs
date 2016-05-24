﻿using System;

namespace Decorator
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/21 23:02:25 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Espresso说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Espresso:Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}