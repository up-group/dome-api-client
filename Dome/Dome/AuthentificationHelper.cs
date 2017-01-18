using Dome.Authentification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Dome
{
    public static class AuthentificationHelper
    {

        private static authenticationDto _auth;
        public static authenticationDto auth
        {
            get
            {
                if (_auth == null)
                {
                    init();
                }
                return _auth;
            }
        }



        private static void init()
        {

            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(ConstHelper.urlbase + "/oauth-soap/DOME_BUS_EAI_R001loginWS");
            var client = new DOME_BUS_EAI_R001loginWSClient(binding, endpoint);
            _auth = client.login(new userInfoDto { username = ConstHelper.username, password = CreateMD5(ConstHelper.password).ToLower() });

        }


        private static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }



}
