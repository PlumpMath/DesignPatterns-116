using System;

namespace State
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/28 19:43:56 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// State说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public abstract class State
    {
        public abstract void WriteProgram(Work work);
    }
}