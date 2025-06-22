using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgePlugin.Enums
{
    public enum DeviceConnectionMethodEnum
    {
        /// <summary>
        /// any usb, serial/rs232, etc
        /// </summary>
        Serial = 0,

        /// <summary>
        /// TCP, UDP, HTTP requests, etc
        /// </summary>
        Network = 1,

        /// <summary>
        /// Dummy/testing or for any other use case
        /// </summary>
        Other = 2,
    }
}
