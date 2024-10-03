using System;
using System.ComponentModel;
using System.Reflection;

namespace LunchSelectSystem.Extension
{
    public static class EnumExtension
    {
        public static string GetDescription(this System.Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = field.GetCustomAttribute<DescriptionAttribute>();

            return attribute == null ? value.ToString() : attribute.Description;
        }


        /// <summary>
        /// 資料轉Enum(相同文字)
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static TEnum ParseEnumForSameWording<TEnum>(this string value) where TEnum : struct
        {
            // Check if TEnum is an enum
            if (!typeof(TEnum).IsEnum)
            {
                throw new ArgumentException("TEnum must be an enum type");
            }

            // 尝试将字符串转换为对应的枚举值
            TEnum enumType;

            bool isParsed = System.Enum.TryParse(value, out enumType);

            if (isParsed && System.Enum.IsDefined(typeof(TEnum), enumType))
            {
                return enumType;
            }
            else
            {
                throw new ArgumentException($"Invalid value '{value}' for enum type {typeof(TEnum).Name}");
            }
        }
    }
}
