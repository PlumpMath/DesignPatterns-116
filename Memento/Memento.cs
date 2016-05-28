using System;

namespace Memento
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/29 6:54:54 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Memento说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Memento
    {
        private string state;

        public string State
        {
            get { return state; }
        }

        public Memento(string state)
        {
            this.state = state;
        }
    }
}