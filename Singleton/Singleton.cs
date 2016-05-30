using System;

namespace Singleton
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/30 22:10:39 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// Singleton说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class Singleton
    {
        ///实现一
        //private static Singleton instance;

        //private Singleton()
        //{
        //}

        //public static Singleton GetInstance()
        //{
        //    if (instance == null)
        //    {
        //        instance = new Singleton();
        //    }
        //    return instance;
        //}

        /// <summary>
        /// 实现二，多线程时的单例
        /// </summary>
        //private static Singleton instance;

        //private static readonly object syncRoot = new object();

        //private Singleton() { }

        //public static Singleton GetInstance()
        //{
        //    lock (syncRoot)
        //    {
        //        if (instance == null)
        //        {
        //            instance = new Singleton();
        //        }
        //    }
        //    return instance;
        //}

        /// <summary>
        /// 实现三，双重锁定
        /// </summary>
        //private static Singleton instance;

        //private static readonly object syncRoot = new object();

        //private Singleton() { }

        //public static Singleton GetInstance()
        //{
        //    if (instance == null)
        //    {
        //        lock (syncRoot)
        //        {
        //            if (instance == null)
        //            {
        //                instance = new Singleton();
        //            }
        //        }
        //    }
        //    return instance;
        //}

        /// <summary>
        /// 实现四，静态初始化
        /// </summary>
        private static readonly Singleton instance = new Singleton();

        private Singleton() { }

        public static Singleton GetInstance()
        {
            return instance;
        }
    }
}