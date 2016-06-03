using System;

namespace Interpreter
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/6/3 20:02:48 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Scale说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Scale : AbstractExpression
    {
        public override void Execute(string key, double value)
        {
            string scale = "";

            switch (Convert.ToInt32(value))
            {
                case 1:
                    scale = "低音";
                    break;
                case 2:
                    scale = "中音";
                    break;
                case 3:
                    scale = "高音";
                    break;
            }

            Console.WriteLine("{0}", scale);
        }
    }
}