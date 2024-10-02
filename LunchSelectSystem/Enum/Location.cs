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
        [Description("Zhongzheng")]
        Zhongzheng,

        /// <summary>
        /// 中山區
        /// </summary>
        [Description("Zhongshan")]
        Zhongshan,

        /// <summary>
        /// 松山區
        /// </summary>
        [Description("Songshan")]
        Songshan,

        /// <summary>
        /// 大安區
        /// </summary>
        [Description("Daan")]
        Daan,

        /// <summary>
        /// 信義區
        /// </summary>
        [Description("Xinyi")]
        Xinyi,

        /// <summary>
        /// 士林區
        /// </summary>
        [Description("Shilin")]
        Shilin,

        /// <summary>
        /// 北投區
        /// </summary>
        [Description("Beitou")]
        Beitou
    }
}
