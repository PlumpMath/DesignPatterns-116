using System;

namespace Observer
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/28 8:46:39 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Boss说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Boss:Subject
    {
        public event EventHandler Update;

        private string action;

        public void Notify()
        {
            Update();
        }

        public string SubjectState
        {
            get
            {
                return action;
            }
            set
            {
                action = value;
            }
        }
    }
}