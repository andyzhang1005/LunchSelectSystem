using System.ComponentModel;

namespace LunchSelectSystem.Enum
{
    /// <summary>
    /// 食物類型
    /// </summary>
    public enum FoodType
    {
        [Description("ChineseMeals")]
        ChineseMeals,

        [Description("JapaneseMeals")]
        JapaneseMeals,

        [Description("ItalianMeals")]
        ItalianMeals,

        [Description("HongKongMeals")]
        HongKongMeals,

        [Description("FrenchMeals")]
        FrenchMeals,
    }
}
