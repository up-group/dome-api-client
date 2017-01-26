using System.Configuration;

namespace Dome
{
    public static class Settings
    {


        public static string Urlbase { get { return ConfigurationManager.AppSettings["Dome_urlBase"]; } }
        public static string Username { get { return ConfigurationManager.AppSettings["Dome_username"]; } }
        public static string Password { get { return ConfigurationManager.AppSettings["Dome_password"]; } }
    }
}
