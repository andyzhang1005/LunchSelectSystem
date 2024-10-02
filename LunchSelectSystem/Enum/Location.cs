using System.ComponentModel;

namespace LunchSelectSystem.Enum
{
    /// <summary>
    /// 地點
    /// </summary>
    public enum Location
    {
        /// <summary>
        /// 中正區
        /// </summary>
        [Description("中正區")]
        Zhongzheng,

        /// <summary>
        /// 中山區
        /// </summary>
        [Description("中山區")]
        Zhongshan,

        /// <summary>
        /// 松山區
        /// </summary>
        [Description("松山區")]
        Songshan,

        /// <summary>
        /// 大安區
        /// </summary>
        [Description("大安區")]
        Daan,

        /// <summary>
        /// 信義區
        /// </summary>
        [Description("信義區")]
        Xinyi,

        /// <summary>
        /// 士林區
        /// </summary>
        [Description("士林區")]
        Shilin,

        /// <summary>
        /// 北投區
        /// </summary>
        [Description("北投區")]
        Beitou
    }
}
