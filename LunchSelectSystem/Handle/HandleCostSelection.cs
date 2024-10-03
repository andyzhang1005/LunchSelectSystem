using LunchSelectSystem.Interface.IStrategy;
using System.Collections.Generic;

namespace LunchSelectSystem.Handle
{
    /// <summary>
    /// 處理選項
    /// </summary>
    public class HandleCostSelection
    {
        private readonly ICostStrategy _costStrategy;

        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="costStrategy">預算對應選項策略</param>
        public HandleCostSelection(ICostStrategy costStrategy)
        {
            _costStrategy = costStrategy;
        }

        /// <summary>
        /// 建議預算
        /// </summary>
        public List<string> RecommendedSelection()
        {
            List<string> selections = _costStrategy.GetRecommendedSelection();

            return selections;
        }
    }
}
