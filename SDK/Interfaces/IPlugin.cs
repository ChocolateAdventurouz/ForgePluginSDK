using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgePlugin.Interfaces
{
    public interface IPlugin
    {
        string Name { get; }
        string Author { get; }
        string Description { get; }
        string AuthorHomepage { get; }
        string DisplayVersion { get; }

        bool Initialize(IPluginContext context);
        void ThrowCrash();
        bool Quit();

        void ShowConfigurationPage();
        void ShowAboutPage();
    }
}
