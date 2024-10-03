using LunchSelectSystem.Interface.IStrategy;
using System.Collections.Generic;

namespace LunchSelectSystem.Handle
{
    /// <summary>
    /// 處理天氣對應地點
    /// </summary>
    public class HandleWeatherLocation
    {
        private readonly IWeatherStrategy _weatherStrategy;

        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="weatherStrategy">天氣對應地點策略</param>
        public HandleWeatherLocation(IWeatherStrategy weatherStrategy)
        {
            _weatherStrategy = weatherStrategy;
        }

        /// <summary>
        /// 建議地點
        /// </summary>
        public List<string> RecommendLocations()
        {
            List<string> locations = _weatherStrategy.GetRecommendedLocations();

            return locations;
        }
    }
}
