using System;

namespace TemplateMethod
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/24 22:26:27 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// ConcreteAlgorithmA说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class ConcreteAlgorithmA : Algorithm
    {
        protected override void Step2()
        {
            Console.WriteLine("ConcreteAlgorithmA.step2");
        }
    }
}