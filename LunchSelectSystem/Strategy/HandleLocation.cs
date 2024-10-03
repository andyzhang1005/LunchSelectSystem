using LunchSelectSystem.Enum;
using LunchSelectSystem.Extension;
using LunchSelectSystem.Interface.IStrategy;
using System.Collections.Generic;

namespace LunchSelectSystem.Strategy
{
    /// <summary>
    /// 處理地點
    /// </summary>
    public class HandleLocation
    {
        /// <summary>
        /// 中正區策略
        /// </summary>
        public class ZhongzhengStrategy : ILocationStrategy
        {
            public List<string> GetRecommendedFoodTypes()
            {

                // 食物類型包含港式餐點、義式餐點、日式餐點
                return new List<string> { FoodType.HongKongMeals.GetDescription(), FoodType.ItalianMeals.GetDescription(), FoodType.JapaneseMeals.GetDescription() };
            }
        }

        /// <summary>
        /// 中山區策略
        /// </summary>
        public class ZhongshanStrategy : ILocationStrategy
        {
            public List<string> GetRecommendedFoodTypes()
            {
                // 食物類型包含中式餐點、義式餐點、日式餐點
                return new List<string> { FoodType.ChineseMeals.GetDescription(), FoodType.ItalianMeals.GetDescription(), FoodType.JapaneseMeals.GetDescription() };
            }
        }

        /// <summary>
        /// 松山區策略
        /// </summary>
        public class SongshanStrategy : ILocationStrategy
        {
            public List<string> GetRecommendedFoodTypes()
            {
                // 食物類型包含中式餐點、港式餐點
                return new List<string> { FoodType.ChineseMeals.GetDescription(), FoodType.HongKongMeals.GetDescription() };
            }
        }

        /// <summary>
        /// 大安區策略
        /// </summary>
        public class DaanStrategy : ILocationStrategy
        {
            public List<string> GetRecommendedFoodTypes()
            {
                // 食物類型包含港式餐點、日式餐點
                return new List<string> { FoodType.HongKongMeals.GetDescription(), FoodType.JapaneseMeals.GetDescription() };
            }
        }

        /// <summary>
        /// 信義區策略
        /// </summary>
        public class XinyiStrategy : ILocationStrategy
        {
            public List<string> GetRecommendedFoodTypes()
            {
                // 食物類型包含港式餐點、義式餐點
                return new List<string> { FoodType.HongKongMeals.GetDescription(), FoodType.ItalianMeals.GetDescription() };
            }
        }

        /// <summary>
        /// 士林區策略
        /// </summary>
        public class ShilinStrategy : ILocationStrategy
        {
            public List<string> GetRecommendedFoodTypes()
            {
                // 食物類型包含港式餐點、法式餐點
                return new List<string> { FoodType.HongKongMeals.GetDescription(), FoodType.FrenchMeals.GetDescription() };
            }
        }

        /// <summary>
        /// 北投區策略
        /// </summary>
        public class BeitouStrategy : ILocationStrategy
        {
            public List<string> GetRecommendedFoodTypes()
            {
                // 食物類型包含日式餐點、法式餐點
                return new List<string> { FoodType.JapaneseMeals.GetDescription(), FoodType.FrenchMeals.GetDescription() };
            }
        }
    }
}
