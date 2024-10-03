using LunchSelectSystem.Interface.IStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LunchSelectSystem.Handle
{
    /// <summary>
    /// 處理預算
    /// </summary>
    public class HandleFoodTypeCost
    {
        private readonly IFoodTypeStrategy _foodTypeStrategy;

        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="foodTypeStrategy">食物類型對應價格策略</param>
        public HandleFoodTypeCost(IFoodTypeStrategy foodTypeStrategy)
        {
            _foodTypeStrategy = foodTypeStrategy;
        }

        /// <summary>
        /// 建議預算
        /// </summary>
        public List<string> RecommendedCost()
        {
            List<string> costs = _foodTypeStrategy.GetRecommendedCost();

            return costs;
        }
    }
}
