using LunchSelectSystem.Enum;
using LunchSelectSystem.Extension;
using LunchSelectSystem.Interface.IStrategy;
using System;
using System.Collections.Generic;
using System.Text;
using static LunchSelectSystem.Strategy.HandleFoodType;
using static LunchSelectSystem.Strategy.HandleLocation;

namespace LunchSelectSystem.Factory
{
    /// <summary>
    /// 預算策略工廠模式
    /// </summary>
    public class CostStrategyFactory
    {
        // 取得食物類型對應策略
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
