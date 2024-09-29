using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgePlugin
{
    public interface IPluginEntry
    {
        [ForgePlugin.Helpers.NotNullOrEmpty]
        string name { get; set; }
        [ForgePlugin.Helpers.NotNullOrEmpty]
        string author { get; set; }
        string description { get; set; }
        string homepage { get; set; }
        [ForgePlugin.Helpers.NotNullOrEmpty]
        string version { get; set; }
        //lazy code temporarily - needs improvement
        [ForgePlugin.Helpers.NotNullOrEmpty]
        string pluginAssemblyName { get; set; }

        // Plugin mandatory methods
        int Initialize();
        void ThrowCrash(Exception ex);
        int Quit();

        // Windows called from settings
        void ShowConfigurationPage();
        void ShowAboutPage();
    }
}
