﻿using System.Collections.Generic;

namespace LunchSelectSystem.Interface.IStrategy
{
    /// <summary>
    /// 天氣對應地點策略
    /// </summary>
    public interface IWeatherStrategy
    {
        /// <summary>
        /// 取得建議的地點
        /// </summary>
        /// <returns></returns>
        List<string> GetRecommendedLocations();
    }
}
