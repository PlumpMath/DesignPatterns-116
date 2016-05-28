using System;

namespace AbstractFactory
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/28 10:38:21 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Department说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Department
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string departmentName;

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
    }
}