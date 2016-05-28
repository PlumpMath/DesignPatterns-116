using System;

namespace State
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/28 19:44:40 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Work说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Work
    {
        private State current;

        public Work()
        {
            current = new ForenoonState();
        }

        private double hour;

        public double Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        private bool finish = false;

        public bool TaskFinished
        {
            get { return finish; }
            set { finish = value; }
        }

        public void SetState(State state)
        {
            current = state;
        }

        public void WriteProgram()
        {
            current.WriteProgram(this);
        }
    }
}