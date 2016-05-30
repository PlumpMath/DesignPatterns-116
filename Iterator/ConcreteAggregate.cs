using System;
using System.Collections.Generic;

namespace Iterator
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/30 20:06:13 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// ConcreteAggregate说明：具体聚集类，继承Aggregate
    /// </summary> 
    public class ConcreteAggregate:Aggregate
    {
        private List<object> items = new List<object>();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get
            {
                return items.Count;
            }
        }

        public object this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items.Insert(index,value);
            }
        }
    }
}