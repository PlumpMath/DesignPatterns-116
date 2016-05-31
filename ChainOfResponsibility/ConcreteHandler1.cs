using System;

namespace ChainOfResponsibility
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/6/1 6:56:18 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// ConcreteHandler1说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class ConcreteHandler1:Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine("{0}处理请求{1}",this.GetType().Name,request);
            }
            else if(successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}