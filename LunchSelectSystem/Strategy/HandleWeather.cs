using LunchSelectSystem.Enum;
using LunchSelectSystem.Extension;
using LunchSelectSystem.Interface.IStrategy;
using System.Collections.Generic;

namespace LunchSelectSystem.Strategy
{
    /// <summary>
    /// 處理天氣
    /// </summary>
    public class WeatherStrategy
    {
        /// <summary>
        /// 晴天策略
        /// </summary>
        public class SunnyWeatherStrategy : IWeatherStrategy
        {
            public List<string> GetRecommendedLocations()
            {

                // 地點包含中山區、中正區、信義區
                return new List<string> { Location.Zhongshan.GetDescription(), Location.Zhongzheng.GetDescription(), Location.Xinyi.GetDescription() };
            }
        }

        /// <summary>
        /// 雨天策略
        /// </summary>
        public class RainyWeatherStrategy : IWeatherStrategy
        {
            public List<string> GetRecommendedLocations()
            {
                // 地點包含北投區、士林區
                return new List<string> { Location.Beitou.GetDescription(), Location.Shilin.GetDescription() };
            }
        }

        /// <summary>
        /// 多雲策略
        /// </summary>
        public class CloudyWeatherStrategy : IWeatherStrategy
        {
            public List<string> GetRecommendedLocations()
            {
                // 地點包含松山區、大安區
                return new List<string> { Location.Songshan.GetDescription(), Location.Daan.GetDescription() };
            }
        }
    }
}
