using LunchSelectSystem.Interface.IStrategy;
using System;
using System.Collections.Generic;
using System.Text;
using static LunchSelectSystem.Strategy.WeatherStrategy;

namespace LunchSelectSystem.Factory
{
    public class WeatherStrategyFactory
    {
        // 取得天氣對應策略
        public static IWeatherStrategy GetWeatherStrategy(string weather)
        {
            return weather switch
            {
                "Sunny" => new SunnyWeatherStrategy(),
                "Rainy" => new RainyWeatherStrategy(),
                "Cloud" => new CloudyWeatherStrategy(),
                _ => throw new ArgumentException("Invalid weather type")
            };
        }
    }
}
