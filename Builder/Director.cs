using System;

namespace Builder
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/26 22:33:10 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Director说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}