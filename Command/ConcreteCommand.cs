using System;

namespace Command
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/31 20:23:11 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// ConcreteCommand说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class ConcreteCommand:Command
    {
        public ConcreteCommand(Receiver receiver)
            : base(receiver)
        { }

        public override void Execute()
        {
            receiver.Action();
        }
    }
}