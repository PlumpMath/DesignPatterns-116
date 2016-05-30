using System;

namespace Iterator
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/30 20:04:19 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// ConcreteIterator说明：具体迭代器类，继承Iterator
    /// </summary> 
    public class ConcreteIterator:Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            ++current;
            if(current <aggregate.Count)
                ret = aggregate[current];
            return ret;
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }

        public override object CurrentItem()
        {
           return aggregate[current];
        }
    }
}