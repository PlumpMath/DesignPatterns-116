using System;

namespace Interpreter
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/6/3 19:59:36 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Note说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Note : AbstractExpression
    {
        public override void Execute(string key, double value)
        {
            string note = "";
            switch (key)
            {
                case "C":
                    note = "1";
                    break;
                case "D":
                    note = "2";
                    break;
                case "E":
                    note = "3";
                    break;
                case "F":
                    note = "4";
                    break;
                case "G":
                    note = "5";
                    break;
                case "A":
                    note = "6";
                    break;
                case "B":
                    note = "7";
                    break;
            }
            Console.WriteLine("{0}", note);
        }
    }
}