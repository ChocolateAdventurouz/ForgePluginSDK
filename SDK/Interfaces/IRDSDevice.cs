using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgePlugin.Enums;

namespace ForgePlugin.Interfaces
{
   public interface IRDSDevice
   {

        string EncoderName { get; set; }

        DeviceConnectionMethodEnum ConnectionMethod { get; set; }

        /// <summary>
        /// Updates "Program Service" (PS) to a new text
        /// </summary>
        /// In case the encoder doesn't support that function, do a return
        /// <param name="psText">The sliced 8-character text that is provided by ForgeAir</param>
        void UpdatePS(string psText);

        /// <summary>
        /// Updates "RadioText" (RT) to a new text
        /// In case the encoder doesn't support that function, do a return
        /// </summary>
        /// <param name="rtText">The sliced 64-character text that is provided by ForgeAir</param>
        void UpdateRT(string rtText);

        /// <summary>
        /// Sets Traffic Programme (TP) status
        /// Enable only if the station transmits traffic programme
        /// In case the encoder doesn't support that function, do a return
        /// </summary>
        /// <param name="enabled"></param>
        void SetTPStatus(bool enabled=false);

        /// <summary>
        /// Sets Traffic Announcement (TA) status
        /// IT SHOULDN'T BE PERMANENTLY ENABLED!
        /// In case the encoder doesn't support that function, do a return
        /// </summary>
        /// <param name="enabled"></param>
        void SetTAStatus(bool enabled=false);
   }


}
