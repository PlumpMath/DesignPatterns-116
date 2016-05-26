using System;

namespace Builder
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/26 22:28:11 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Builder说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetProduct();
    }
}