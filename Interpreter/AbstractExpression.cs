using System;

namespace Interpreter
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/6/3 19:41:33 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// AbstractExpression说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public abstract class AbstractExpression
    {
        public void Interpret(Context context)
        {
            if (context.PlayText.Length == 0)
            {
                return; 
            }
            else
            {
                string playKey = context.PlayText.Substring(0,1);
                context.PlayText = context.PlayText.Substring(2);
                double playValue = Convert.ToDouble(context.PlayText.Substring(0,context.PlayText.IndexOf(" ")));
                context.PlayText = context.PlayText.Substring(context.PlayText.IndexOf(" ")+1);

                Execute(playKey,playValue);
            }
        }

        public abstract void Execute(string key,double value);
    }
}