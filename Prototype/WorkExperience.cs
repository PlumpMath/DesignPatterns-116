using System;

namespace Prototype
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/24 19:46:36 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// WorkExperience说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class WorkExperience:ICloneable
    {
        private string workData;

        public string WorkData
        {
            get { return workData; }
            set { workData = value; }
        }

        private string company;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}