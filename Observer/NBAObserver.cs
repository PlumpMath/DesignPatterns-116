using System;

namespace Observer
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/28 8:42:40 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// NBAObserver说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class NBAObserver
    {
        private string name;
        private Subject subject;

        public NBAObserver(string name,Subject subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public void CloseNBADirectSeeding()
        {
            Console.WriteLine("{0}{1} 关闭NBA直播，继续工作！",subject.SubjectState,name);
        }
    }
}