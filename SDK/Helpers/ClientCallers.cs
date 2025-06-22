using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgePlugin.Enums;
using ForgePlugin.Interfaces;

namespace ForgePlugin.Helpers
{
    public interface IClientCalls
    {
        bool isHighEndMachine { get; }
        string CLIENT_GET_VERSION();
    }

    public interface IConfigurationManager
    {
        string GetString(string key);
        bool GetBool(string key);
        int GetInt(string key);
        void SetSetting(string key, string value);
    }
    public interface ILogger
    {
        void Log(LoggerSeverityEnum severity, string message, Exception? ex = null);
    }
}
