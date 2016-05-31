using System;

namespace Command
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/31 20:20:44 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Command说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
}