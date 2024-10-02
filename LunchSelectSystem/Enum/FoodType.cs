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
        [Description("中式餐點")]
        ChineseMeals,

        [Description("日式餐點")]
        JapaneseMeals,

        [Description("義式餐點")]
        ItalianMeals,

        [Description("港式餐點")]
        HongKongMeals,

        [Description("法式餐點")]
        FrenchMeals,
    }
}
