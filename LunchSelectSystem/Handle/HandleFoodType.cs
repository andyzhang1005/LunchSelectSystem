using LunchSelectSystem.Interface.IStrategy;
using System.Collections.Generic;

namespace LunchSelectSystem.Handle
{
    /// <summary>
    /// 處理食物類型
    /// </summary>
    public class HandleLocationFoodType
    {
        private readonly ILocationStrategy _locationStrategy;

        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="locationStrategy">地點對應食物類型策略</param>
        public HandleLocationFoodType(ILocationStrategy locationStrategy)
        {
            _locationStrategy = locationStrategy;
        }

        /// <summary>
        /// 建議食物類型
        /// </summary>
        public List<string> RecommendedFoodTypes()
        {
            List<string> foodTypes = _locationStrategy.GetRecommendedFoodTypes();

            return foodTypes;
        }
    }
}
