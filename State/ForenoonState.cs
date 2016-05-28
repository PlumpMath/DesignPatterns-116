using System;

namespace State
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/28 19:45:39 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// ForenoonState说明：上午工作状态
    /// </summary> 
    public class ForenoonState:State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 12)
            {
                Console.WriteLine("当前时间：{0}点 上午工作，精神百倍",work.Hour);
            }
            else
            {
                work.SetState(new NoonState());
                work.WriteProgram();
            }
        }
    }
}