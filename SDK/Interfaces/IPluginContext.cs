using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgePlugin.Helpers;

namespace ForgePlugin.Interfaces
{
    public interface IPluginContext
    {
        IClientCalls Client { get; }
        IConfigurationManager Config { get;}
        ILogger Logger { get; }

        /// <summary>
        /// Leave it null if the plugin is not an RDS Encoder driver
        /// </summary>
        IRDSDevice? RDSEncoder { get; set; }

        /// <summary>
        /// Leave it null if the plugin is not an Audio Player
        /// </summary>
        IAudioPlayer? AudioPlayer { get; set; }
    }
}
