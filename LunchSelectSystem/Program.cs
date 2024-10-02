using LunchSelectSystem.Factory;
using LunchSelectSystem.Handle;
using LunchSelectSystem.Interface.IStrategy;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LunchSelectSystem
{
    class Program
    {
        // Main Program
        static void Main(string[] args)
        {
            // Sort Wether => Location => Type => Cost => Selection
            // 假設使用者選擇了天氣 "Sunny"
            string selectedWeather = "Sunny";

            #region 天氣對應地點區塊

            // 透過工廠模式獲取對應的天氣策略
            IWeatherStrategy weatherStrategy = WeatherStrategyFactory.GetWeatherStrategy(selectedWeather);

            // 應用策略模式決定推薦地點
            HandleWeatherLocation handleWeatherLocation = new HandleWeatherLocation(weatherStrategy);
            List<string> locations = handleWeatherLocation.RecommendLocations();

            #endregion

            #region 地點對應食物類型區塊

            List<string> allFoodTypes = new List<string>();

            locations.ForEach(location =>
            {
                // 透過工廠模式獲取對應的地點策略
                ILocationStrategy locationStrategy = LocationStrategyFactory.GetLocationStrategy(location);

                // 應用策略模式決定推薦食物類型
                HandleLocationFoodType handleLocationFoodType = new HandleLocationFoodType(locationStrategy);
                List<string> foodTypes = handleLocationFoodType.RecommendedFoodTypes();

                allFoodTypes.AddRange(foodTypes);
               
            });

            #endregion

            // 過濾相同的資料
            allFoodTypes = FilterSameData(allFoodTypes);

            allFoodTypes.ForEach(foodType =>
            {
                Console.WriteLine(foodType);
            });
           
        }

        /// <summary>
        /// 過濾相同的資料
        /// </summary>
        /// <param name="filterList"></param>
        /// <returns></returns>
        private static List<string> FilterSameData(List<string> filterList)
        {
            return filterList.Distinct().ToList();
        }
    }
}
