using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dome
{
    public static class settings
    {


        public static string urlbase { get { return ConfigurationManager.AppSettings["Dome_urlBase"]; } }
        public static string username { get { return ConfigurationManager.AppSettings["Dome_username"]; } }
        public static string password { get { return ConfigurationManager.AppSettings["Dome_password"]; } }
    }
}
