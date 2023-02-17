using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XS.Core2;

namespace XS.ModuleForCore
{
    public class Settings
    {
        public readonly static Settings Instance = new Settings();
        private IniParser iniParser;

        private Settings()
        { 
            string sPath = AppDomain.CurrentDomain.BaseDirectory;
#if DEBUG
            if (sPath.EndsWith("\\bin"))
                sPath = sPath.Replace("\\bin", "");
#endif
            iniParser = new IniParser(string.Concat(sPath, @"\conf\conf.ini"));

            //app
            DbConn = iniParser.GetSetting("App", "DbConn");
            Email = iniParser.GetSetting("App", "Email"); 


        }

        public void Save()
        {
            //app
            iniParser.AddSetting("App", "DbConn", DbConn);
            iniParser.AddSetting("App", "Email", Email); 

            iniParser.SaveSettings();

        }


        //app
        public string DbConn { get; set; }
        public string Email { get; set; } 
    }
}
