using LunchSelectSystem.Enum;
using LunchSelectSystem.Extension;
using LunchSelectSystem.Interface.IStrategy;
using System;
using static LunchSelectSystem.Strategy.HandleFoodType;

namespace LunchSelectSystem.Factory
{
    /// <summary>
    /// 預算策略工廠模式
    /// </summary>
    public class CostStrategyFactory
    {
        /// <summary>
        /// 取得食物類型對應策略
        /// </summary>
        /// <param name="selectfoodType">食物類型</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static IFoodTypeStrategy GetFoodTypeStrategy(string selectfoodType)
        {
            FoodType foodType = selectfoodType.ParseEnumForSameWording<FoodType>();

            return foodType switch
            {
                FoodType.ChineseMeals => new ChineseMealsStrategy(),
                FoodType.JapaneseMeals => new JapaneseMealsStrategy(),
                FoodType.ItalianMeals => new ItalianMealsStrategy(),
                FoodType.HongKongMeals => new HongKongMealsStrategy(),
                FoodType.FrenchMeals => new FrenchMealsStrategy(),
                _ => throw new ArgumentException("Invalid weather type")
            };
        }
    }
}
