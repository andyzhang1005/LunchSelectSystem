using System.Collections.Generic;

namespace LunchSelectSystem.Interface.IStrategy
{
    /// <summary>
    /// 預算對應選項策略
    /// </summary>
    public interface ICostStrategy
    {
        /// <summary>
        /// 取得建議的選項
        /// </summary>
        /// <returns></returns>
        List<string> GetRecommendedSelection();
    }
}
