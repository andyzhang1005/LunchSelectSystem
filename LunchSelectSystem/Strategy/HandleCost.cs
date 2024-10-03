using LunchSelectSystem.Enum;
using LunchSelectSystem.Extension;
using LunchSelectSystem.Interface.IStrategy;
using System.Collections.Generic;

namespace LunchSelectSystem.Strategy
{
    /// <summary>
    /// 處理食物類型
    /// </summary>
    public class HandleCost
    {
        /// <summary>
        /// 低於500元策略
        /// </summary>
        public class UnderFiveHundredStrategy : ICostStrategy
        {
            public List<string> GetRecommendedSelection()
            {

                // 選項包含 Rosemary
                return new List<string> { Selection.Rosemary.GetDescription() };
            }
        }

        /// <summary>
        /// 低於1000元策略
        /// </summary>
        public class UnderOneThousandStrategy : ICostStrategy
        {
            public List<string> GetRecommendedSelection()
            {

                // 選項包含 DimDimSum
                return new List<string> { Selection.DimDimSum.GetDescription() };
            }
        }

        /// <summary>
        /// 低於2000元策略
        /// </summary>
        public class UnderTwoThousandStrategy : ICostStrategy
        {
            public List<string> GetRecommendedSelection()
            {

                // 選項包含 Longyue、TienHsiangLo
                return new List<string> { Selection.Longyue.GetDescription(), Selection.TienHsiangLo.GetDescription() };
            }
        }

        /// <summary>
        /// 低於3000元策略
        /// </summary>
        public class OverTwoThousandStrategy : ICostStrategy
        {
            public List<string> GetRecommendedSelection()
            {

                // 選項包含 CLOVERBELLAVITA、JKSTUDIO
                return new List<string> { Selection.CLOVERBELLAVITA.GetDescription(), Selection.JKSTUDIO.GetDescription() };
            }
        }

    }
}
