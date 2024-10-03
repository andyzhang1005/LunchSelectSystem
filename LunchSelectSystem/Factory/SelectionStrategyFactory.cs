using LunchSelectSystem.Enum;
using LunchSelectSystem.Extension;
using LunchSelectSystem.Interface.IStrategy;
using System;
using static LunchSelectSystem.Strategy.HandleCost;

namespace LunchSelectSystem.Factory
{
    /// <summary>
    /// 選項策略工廠模式
    /// </summary>
    public class SelectionStrategyFactory
    {
        /// <summary>
        /// 取得預算對應策略
        /// </summary>
        /// <param name="selectionCost">預算</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static ICostStrategy GetCostStrategy(string selectionCost)
        {
            Cost cost = selectionCost.ParseEnumForSameWording<Cost>();

            return cost switch
            {
                Cost.UnderFiveHundred => new UnderFiveHundredStrategy(),
                Cost.UnderOneThousand => new UnderOneThousandStrategy(),
                Cost.UnderTwoThousand => new UnderTwoThousandStrategy(),
                Cost.OverTwoThousand => new OverTwoThousandStrategy(),
                _ => throw new ArgumentException("Invalid weather type")
            };
        }
    }
}
