using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

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
