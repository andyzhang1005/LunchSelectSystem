using LunchSelectSystem.Interface.IStrategy;
using System;
using System.Collections.Generic;
using System.Text;
using static LunchSelectSystem.Strategy.HandleLocation;

namespace LunchSelectSystem.Factory
{
    /// <summary>
    /// 食物類型策略工廠模式
    /// </summary>
    public class LocationStrategyFactory
    {
        // 取得地點對應策略
        public static ILocationStrategy GetLocationStrategy(string location)
        {
            return location switch
            {
                "Zhongzheng" => new ZhongzhengStrategy(),
                "Zhongshan" => new ZhongshanStrategy(),
                "Songshan" => new SongshanStrategy(),
                "Daan" => new DaanStrategy(),
                "Xinyi" => new XinyiStrategy(),
                "Shilin" => new ShilinStrategy(),
                "Beitou" => new BeitouStrategy(),
                _ => throw new ArgumentException("Invalid weather type")
            };
        }
    }
}
