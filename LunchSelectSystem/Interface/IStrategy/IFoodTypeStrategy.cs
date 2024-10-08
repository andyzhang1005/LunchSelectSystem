﻿using System.Collections.Generic;

namespace LunchSelectSystem.Interface.IStrategy
{
    /// <summary>
    /// 食物類型對應價格策略
    /// </summary>
    public interface IFoodTypeStrategy
    {
        /// <summary>
        /// 取得建議的預算
        /// </summary>
        /// <returns></returns>
        List<string> GetRecommendedCost();
    }
}
