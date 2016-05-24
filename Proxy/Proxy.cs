using System;

namespace Proxy
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/23 7:19:27 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Proxy说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Proxy:Subject
    {
        private Subject realSubject = null;
        private string _name;

        public Proxy(string _name)
        {
            this._name = _name;
        }

        public override void Request()
        {
            if (realSubject == null)
                LoadRealSubject();
            realSubject.Request();
        }

        public override string Name
        {
            get { return _name; }
        }

        private void LoadRealSubject()
        {
            ///do some heavy things
            realSubject = new RealSubject(_name);
        }
    }
}