using LunchSelectSystem.Enum;
using LunchSelectSystem.Extension;
using LunchSelectSystem.Interface.IStrategy;
using System.Collections.Generic;

namespace LunchSelectSystem.Strategy
{
    /// <summary>
    /// 處理食物類型
    /// </summary>
    public class HandleFoodType
    {
        /// <summary>
        /// 中式餐點策略
        /// </summary>
        public class ChineseMealsStrategy : IFoodTypeStrategy
        {
            public List<string> GetRecommendedCost()
            {

                // 價格類型包含 [<500]、[<1000]
                return new List<string> { Cost.UnderFiveHundred.GetDescription(), Cost.UnderOneThousand.GetDescription() };
            }
        }

        /// <summary>
        /// 日式餐點策略
        /// </summary>
        public class JapaneseMealsStrategy : IFoodTypeStrategy
        {
            public List<string> GetRecommendedCost()
            {

                // 價格類型包含 [<500]、[<1000]、[<2000]
                return new List<string> { Cost.UnderFiveHundred.GetDescription(), Cost.UnderOneThousand.GetDescription(), Cost.UnderTwoThousand.GetDescription() };
            }
        }

        /// <summary>
        /// 義式餐點策略
        /// </summary>
        public class ItalianMealsStrategy : IFoodTypeStrategy
        {
            public List<string> GetRecommendedCost()
            {

                // 價格類型包含 [<1000]、[<2000]
                return new List<string> { Cost.UnderOneThousand.GetDescription(), Cost.UnderTwoThousand.GetDescription() };
            }
        }

        /// <summary>
        /// 港式餐點策略
        /// </summary>
        public class HongKongMealsStrategy : IFoodTypeStrategy
        {
            public List<string> GetRecommendedCost()
            {

                // 價格類型包含 [<1000]、[<2000]
                return new List<string> { Cost.UnderOneThousand.GetDescription(), Cost.UnderTwoThousand.GetDescription() };
            }
        }

        /// <summary>
        /// 法式餐點策略
        /// </summary>
        public class FrenchMealsStrategy : IFoodTypeStrategy
        {
            public List<string> GetRecommendedCost()
            {

                // 價格類型包含 [<1000]、[<2000]、[>2000]
                return new List<string> { Cost.UnderOneThousand.GetDescription(), Cost.UnderTwoThousand.GetDescription(), Cost.OverTwoThousand.GetDescription() };
            }
        }
    }
}
