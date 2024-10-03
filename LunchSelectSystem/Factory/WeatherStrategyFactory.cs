using LunchSelectSystem.Enum;
using LunchSelectSystem.Extension;
using LunchSelectSystem.Interface.IStrategy;
using System;
using static LunchSelectSystem.Strategy.WeatherStrategy;

namespace LunchSelectSystem.Factory
{
    /// <summary>
    /// 天氣策略工廠模式
    /// </summary>
    public class WeatherStrategyFactory
    {
        /// <summary>
        /// 取得天氣對應策略
        /// </summary>
        /// <param name="selectWeather">天氣</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static IWeatherStrategy GetWeatherStrategy(string selectWeather)
        {
            Weather weather = selectWeather.ParseEnumForSameWording<Weather>();

            return weather switch
            {
                Weather.Sunny => new SunnyWeatherStrategy(),
                Weather.Rainy => new RainyWeatherStrategy(),
                Weather.Cloud => new CloudyWeatherStrategy(),
                _ => throw new ArgumentException("Invalid weather type")
            };
        }
    }
}
