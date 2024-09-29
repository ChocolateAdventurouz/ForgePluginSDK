using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgePlugin.Helpers
{
    public interface IClientCallers
    {
        bool isHighEndMachine { get; }
        string CLIENT_GET_VERSION();
    }

    public interface IConfigurationManager
    {
        string RetreiveSetting(string key, IPluginEntry plugin);
        void SetSetting(string key, string value, IPluginEntry plugin);
    }
}
