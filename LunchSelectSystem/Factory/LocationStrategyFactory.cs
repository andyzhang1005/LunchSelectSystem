using LunchSelectSystem.Enum;
using LunchSelectSystem.Extension;
using LunchSelectSystem.Interface.IStrategy;
using System;
using static LunchSelectSystem.Strategy.HandleLocation;

namespace LunchSelectSystem.Factory
{
    /// <summary>
    /// 食物類型策略工廠模式
    /// </summary>
    public class LocationStrategyFactory
    {
        /// <summary>
        ///  取得地點對應策略
        /// </summary>
        /// <param name="selectlocation">地點</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static ILocationStrategy GetLocationStrategy(string selectlocation)
        {
            Location location = selectlocation.ParseEnumForSameWording<Location>();

            return location switch
            {
                Location.Zhongzheng => new ZhongzhengStrategy(),
                Location.Zhongshan => new ZhongshanStrategy(),
                Location.Songshan => new SongshanStrategy(),
                Location.Daan => new DaanStrategy(),
                Location.Xinyi => new XinyiStrategy(),
                Location.Shilin => new ShilinStrategy(),
                Location.Beitou => new BeitouStrategy(),
                _ => throw new ArgumentException("Invalid weather type")
            };
        }
    }
}
