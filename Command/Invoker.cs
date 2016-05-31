using System;

namespace Command
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/31 20:24:58 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Invoker说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Invoker
    {
        private Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

       public void ExecuteCommand()
       {
           command.Execute();
       }
    }
}