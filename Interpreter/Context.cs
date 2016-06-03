using System;

namespace Interpreter
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/6/3 19:42:24 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Context说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Context
    {
        private string text;

        public string PlayText
        {
            get { return text; }
            set { text = value; }
        }
    }
}