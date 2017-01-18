using Dome.Authentification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Dome
{



    public class AuthentificationHelper
    {

        public class DOME_header
        {
            public string version { get; set; }
            public DateTime? date { get { return DateTime.Now; } }
        }

        public class AuthentificationResultDto
        {

            public int? statusId { get; set; }
            public string token { get; set; }
            public string statusUserMessage { get; set; }
            public string statusErrorMessage { get; set; }
            public string refresh_token { get; set; }
            public DOME_header DOME_header { get; set; }
            public int? expires_in { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
            public int? accountId { get; set; }

        }





        private static AuthentificationHelper instance;

        private AuthentificationHelper() { }

        public Boolean isConnected { get; set; }
        public AuthentificationResultDto auth { get; set; }

        public static AuthentificationHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AuthentificationHelper();
                }
                return instance;
            }
        }

        public void connect(string username, string pass)
        {
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                                {
                       { "username", username },
                       { "rememberMe", "false" },
                       { "password", CreateMD5(pass).ToLower() }
                    };
                var j = new JavaScriptSerializer();
                var httpContent = new StringContent(j.Serialize(values), Encoding.UTF8, "application/json");


                var response = client.PostAsync("http://dev.mondome.fr/oauth/token", httpContent).Result;


                var responseString = response.Content.ReadAsStringAsync();

                auth = (AuthentificationResultDto)j.Deserialize(responseString.Result, typeof(AuthentificationResultDto));

                isConnected = (String.IsNullOrWhiteSpace(auth.statusErrorMessage));
                //throw new System.Exception(auth.statusErrorMessage);
            }
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


    //public static class AuthaentificationHelper
    //{

    //    public static void connect(string username, string pass)
    //    {
    //        using (var client = new HttpClient())
    //        {
    //            var values = new Dictionary<string, string>
    //                            {
    //                   { "usernam", username },
    //                   { "rememberMe", "false" },
    //                   { "password", CreateMD5(pass).ToLower() }
    //                };
    //            var j = new JavaScriptSerializer();
    //            var httpContent = new StringContent(j.Serialize(values), Encoding.UTF8, "application/json");


    //            var response = client.PostAsync("http://dev.mondome.fr/oauth/token", httpContent).Result;


    //            var responseString = response.Content.ReadAsStringAsync();

    //            auth = (testAuth)j.Deserialize(responseString.Result, typeof(testAuth));

    //            if (String.IsNullOrWhiteSpace(auth.statusErrorMessage) == false)
    //            {
    //                isConnect = false;
    //                //throw new System.Exception(auth.statusErrorMessage);
    //            }
    //            isConnect = true;
    //        }
    //    }










    //}



}
