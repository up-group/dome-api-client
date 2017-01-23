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
        public static string urlbase { get { return ConfigurationManager.AppSettings["urlbase"]; } }
        public static string username { get { return ConfigurationManager.AppSettings["username"]; } }
        public static string password { get { return ConfigurationManager.AppSettings["password"]; } }
    }
}
