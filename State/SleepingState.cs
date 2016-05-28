using System;

namespace State
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/28 19:58:45 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// SleepingState说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class SleepingState:State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine("当前时间：{0}点 不行了，睡着了！", work.Hour);
        }
    }
}