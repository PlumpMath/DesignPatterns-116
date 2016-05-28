using System;

namespace Memento
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/29 6:59:40 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Caretaker说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Caretaker
    {
        private Memento memento;

        public Memento Memento
        {
            get { return memento; }
            set { memento = value; }
        }
    }
}