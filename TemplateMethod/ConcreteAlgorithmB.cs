using System;

namespace TemplateMethod
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/24 22:27:42 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// ConcreteAlgorithmB说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class ConcreteAlgorithmB:Algorithm
    {
        protected override void Step2()
        {
            Console.WriteLine("ConcreteAlgorithmB.step2");
        }

        protected override void Step3WithDefault()
        {
            Console.WriteLine("ConcreteAlgorithmB.step3");
        }
    }
}