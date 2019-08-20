using System;
using System.Xml;
using System.Xml.XPath;

namespace DBFill.Core
{
    class SettingsManager
    {
        private string settingsFile;
        
        public SettingsManager(string settingsFile)
        {
            this.settingsFile = settingsFile;
        }
    }
}