using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgePlugin
{
   public interface IRDSDevice
    {
        [ForgePlugin.Helpers.NotNullOrEmpty]
        string encoderName { get; set; }

        [ForgePlugin.Helpers.NotNullOrEmpty]
        bool rdsDynamicPSCapable {  get; set; }
        [ForgePlugin.Helpers.NotNullOrEmpty]
        bool rdsStaticPSCapable { get; set; }
        [ForgePlugin.Helpers.NotNullOrEmpty]
        bool rdsRTCapable { get; set; }
        [ForgePlugin.Helpers.NotNullOrEmpty]
        string encoderConnectionMethod { get; set; }

        void UpdatePSText(string psText);
        void UpdateRTText(string rtText);
        void ChangeTP(int tp);
        void ChangeTA(int ta);
    }


}
