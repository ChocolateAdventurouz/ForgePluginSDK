using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgePlugin.Enums
{
    /// <summary>
    /// Every log the plugin sends, it will be captured to ForgeAir's event log
    /// </summary>
    public enum LoggerSeverityEnum
    {
        /// <summary>
        /// Will be displayed in a messagebox
        /// its recommended to use the #DEBUG preprocessor for that
        /// </summary>
        Debug = 0,
        Info = 1,
        Warn = 2,
        /// <summary>
        /// Will be displayed to the user in a messagebox
        /// </summary>
        Error = 3,
        /// <summary>
        /// If any Fatal log is sent to ForgeAir, ForgeAir will kill the plugin's instance
        /// </summary>
        Fatal = 4,
    }
}
