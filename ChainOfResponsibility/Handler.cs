using System;

namespace ChainOfResponsibility
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/6/1 6:54:00 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Handler说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);
    }
}