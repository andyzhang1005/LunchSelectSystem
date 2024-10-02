using System;
using System.Collections.Generic;
using System.Text;

namespace LunchSelectSystem.Interface.IStrategy
{
    /// <summary>
    /// 地點對應食物類型策略
    /// </summary>
    public interface ILocationStrategy
    {
        /// <summary>
        /// 取得建議的食物類型
        /// </summary>
        /// <returns></returns>
        List<string> GetRecommendedFoodTypes();
    }
}
