using System;

namespace Builder
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/26 22:32:04 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// ConcreteBuilder2说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class ConcreteBuilder2:Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("部件 X");
        }

        public override void BuildPartB()
        {
            product.Add("部件 Y");
        }

        public override Product GetProduct()
        {
            return product;
        }
    }
}