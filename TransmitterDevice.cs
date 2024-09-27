using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ForgePlugin
{
    public interface ITransmitterDevice
    {
        // Device Properties
        [ForgePlugin.Helpers.NotNullOrEmpty]
        string deviceName { get; set; }
        [ForgePlugin.Helpers.NotNullOrEmpty]
        string deviceConnectionMethod { get; set; }

        // Transmitter Properties
        enum AudioTypes { Stereo, Mono };
        [ForgePlugin.Helpers.NotNullOrEmpty]
        bool canChangeFreq { get; set; }
        [ForgePlugin.Helpers.NotNullOrEmpty]
        bool canChangePower { get; set; }
        [ForgePlugin.Helpers.NotNullOrEmpty]
        bool stereoCapable { get; set; }

        /* in-built RDS Encoder Properties (if capable)
        [ForgePlugin.Helpers.NotNullOrEmpty]
        bool rdsPSCapable { get; set; }
        [ForgePlugin.Helpers.NotNullOrEmpty]
        bool rdsRTCapable { get; set; }*/


        // Out-To-Transmitter
        void ChangeFrequency(double frequency);
        void RegulateOutPower(int watts);
        void SwitchAudioType(AudioTypes type);
        
        /* RDS Encoder Specific (referenced in RDSDevice.cs)
        void UpdatePSText(string psText);
        void UpdateRTText(string rtText);
        void ChangeTP(int tp);
        void ChangeTA(int ta);*/

        // Transmitter Received Data - varies on transmitter
        double GetFrequency();
        int GetPowerPrecentage();
        AudioTypes GetAudioType();
    }
}
