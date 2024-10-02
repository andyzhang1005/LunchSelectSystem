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
    }
}
