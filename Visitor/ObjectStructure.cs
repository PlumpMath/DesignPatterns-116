using System;
using System.Collections.Generic;

namespace Visitor
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/6/4 6:38:05 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// ObjectStructure说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class ObjectStructure
    {
        private List<Element> elements = new List<Element>();

        public void Attach(Element element)
        {
            elements.Add(element);
        }

        public void Detach(Element element)
        {
            elements.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}