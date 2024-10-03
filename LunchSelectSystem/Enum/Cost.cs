using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LunchSelectSystem.Enum
{
    /// <summary>
    /// 預算
    /// </summary>
    public enum Cost
    {
        [Description("UnderFiveHundred")]
        UnderFiveHundred,

        [Description("UnderOneThousand")]
        UnderOneThousand,

        [Description("UnderTwoThousand")]
        UnderTwoThousand,

        [Description("OverTwoThousand")]
        OverTwoThousand
    }
}
