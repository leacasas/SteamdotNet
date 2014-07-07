using System.ComponentModel;

namespace SteamdotNet.Common
{
    /// <summary>
    /// Contains all three output options
    /// </summary>
    public enum OutputFileFormat
    {
        /// <summary>
        /// JSON output
        /// </summary>
        [Description("Output format = JSON")]
        JSON,

        /// <summary>
        /// XML output
        /// </summary>
        [Description("Output format = XML")]
        XML,

        /// <summary>
        /// Valve Data Format output
        /// </summary>
        [Description("Output format = VDF")]
        VDF
    }
}