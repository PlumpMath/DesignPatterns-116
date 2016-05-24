using System;

namespace Prototype
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/24 19:36:45 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Resume说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Resume:ICloneable
    {
        private string name;
        private string sex;
        private string age;

        private WorkExperience workExperience;

        public Resume(string name)
        {
            this.name = name;
            workExperience = new WorkExperience();
        }

        private Resume(WorkExperience work)
        {
            this.workExperience = (WorkExperience)work.Clone();
        }

        public void SetPersonalInfo(string sex,string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExperience(string timeArea,string company)
        {
            workExperience.WorkData = timeArea;
            workExperience.Company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0}{1}{2}",name,sex,age);
            Console.WriteLine("工作经历：{0}{1}", workExperience.WorkData, workExperience.Company);
        }

        public object Clone()
        {
            Resume obj = new Resume(this.workExperience);
            obj.name = this.name;
            obj.sex = this.sex;
            obj.age = this.age;

            return obj;
        }
    }
}