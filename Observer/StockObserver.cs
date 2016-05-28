using System;

namespace Observer
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/28 8:37:06 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// StockObserver说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class StockObserver
    {
        private string name;
        private Subject subject;

        public StockObserver(string name,Subject subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public void CloseStockMarket()
        {
            Console.WriteLine("{0}{1} 关闭股票行情,继续工作！",subject.SubjectState,name);
        }
    }
}