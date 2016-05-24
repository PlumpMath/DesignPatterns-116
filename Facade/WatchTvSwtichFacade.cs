using System;

namespace Facade
{
    /// <summary> 
    /// 作者：bzyzhang
    /// 时间：2016/5/25 7:43:50 
    /// 博客地址：http://www.cnblogs.com/bzyzhang/
    /// WatchTvSwtichFacade说明：本代码版权归bzyzhang所有，使用时必须带上bzyzhang博客地址 
    /// </summary> 
    public class WatchTvSwtichFacade
    {
        Appliance television;
        Appliance light;
        Appliance airCondition;
        Appliance screen;

        public WatchTvSwtichFacade()
        {
            television = new Television("电视");
            light = new Light("电灯");
            airCondition = new AirCondition("空调");
            screen = new Screen("银幕");
        }

        public void On()
        {
            television.On();
            light.On();
            airCondition.On();
            screen.On();
        }

        public void Off()
        {
            television.Off();
            light.Off();
            airCondition.Off();
            screen.Off();
        }
    }
}