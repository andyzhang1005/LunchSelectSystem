using LunchSelectSystem.Factory;
using LunchSelectSystem.Handle;
using LunchSelectSystem.Interface.IStrategy;
using System;
using System.Collections.Generic;

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

            // 透過工廠模式獲取對應的天氣策略
            IWeatherStrategy weatherStrategy = WeatherStrategyFactory.GetWeatherStrategy(selectedWeather);

            // 應用策略模式決定推薦地點
            HandleWeatherLocation handleWeatherLocation = new HandleWeatherLocation(weatherStrategy);
            List<string> locations = handleWeatherLocation.RecommendLocations();

            locations.ForEach(location =>
            {
                Console.WriteLine(location);
            });
        }
    }
}
