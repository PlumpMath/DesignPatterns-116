using System;

namespace Mediator
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/6/1 22:05:57 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// ConcreteColleague2说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator)
            : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("同事2得到消息：" + message);
        }
    }
}