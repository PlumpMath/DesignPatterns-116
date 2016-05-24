using System;

namespace Proxy
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/23 7:18:34 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// RealSubject说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class RealSubject:Subject
    {
        private string _name;

        public RealSubject(string _name)
        {
            this._name = _name;
        }

        public override void Request()
        {
            Console.WriteLine(_name);
        }

        public override string Name
        {
            get { return _name; }
        }
    }
}