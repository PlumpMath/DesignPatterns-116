using System;

namespace Memento
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/29 6:56:24 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Originator说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Originator
    {
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        public void SetMemento(Memento memento)
        {
            this.state = memento.State;
        }

        public void Show()
        {
            Console.WriteLine("state=" + state);
        }
    }
}