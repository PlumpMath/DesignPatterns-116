using System;

namespace State
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/28 19:56:32 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// EveningState说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class EveningState:State
    {
        public override void WriteProgram(Work work)
        {
            if (work.TaskFinished)
            {
                work.SetState(new RestState());
                work.WriteProgram();
            }
            else
            {
                if (work.Hour < 21)
                {
                    Console.WriteLine("当前时间：{0}点 加班哦，疲累至极！", work.Hour);
                }
                else
                {
                    work.SetState(new SleepingState());
                    work.WriteProgram();
                }
            }
        }
    }
}