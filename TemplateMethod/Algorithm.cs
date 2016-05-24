using System;

namespace TemplateMethod
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/24 22:23:20 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Algorithm说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public abstract class Algorithm
    {
        public void TemplateMethod()
        {
            Step1CanNotBeCustomized();
            Step2();
            Step3WithDefault();
        }

        private void Step1CanNotBeCustomized()
        {
            Console.WriteLine("step1");
        }

        protected abstract void Step2();

        protected virtual void Step3WithDefault()
        {
            Console.WriteLine("step3");
        }
    }
}