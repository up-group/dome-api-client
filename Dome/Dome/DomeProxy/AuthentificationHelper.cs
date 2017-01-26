using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Web.Script.Serialization;
using Dome.Client;

namespace Dome.DomeProxy
{

    public class AuthentificationHelper
    {
        public class DomeHeader
        {
            public string Version { get; set; }
            public DateTime Date
            {
                get
                {
                    return new DateTimeOffset(DateTime.Now.Ticks, TimeSpan.Zero).DateTime;
                }

            }
        }

        public class AuthentificationResultDto
        {
            public int? StatusId { get; set; }
            public string Token { get; set; }
            public string StatusUserMessage { get; set; }
            public string StatusErrorMessage { get; set; }
            public string RefreshToken { get; set; }
            public DomeHeader DomeHeader { get; set; }
            public int? ExpiresIn { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public int AccountId { get; set; }
        }


        private static AuthentificationHelper _instance;

        private AuthentificationHelper() { }

        public Boolean IsConnected { get; set; }
        public AuthentificationResultDto Auth { get; set; }
        public int? MainProfilId { get; set; }

        public static AuthentificationHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AuthentificationHelper();
                }
                return _instance;
            }
        }


        public void Connect()
        {
            Connect(Settings.Username, Settings.Password);
        }

        public void Connect(string username, string pass)
        {
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                       { "username", username },
                       { "rememberMe", "false" },
                       { "password", CreateMd5(pass).ToLower() }
                };

                var j = new JavaScriptSerializer();
                var httpContent = new StringContent(j.Serialize(values), Encoding.UTF8, "application/json");

                var response = client.PostAsync("http://dev.mondome.fr/oauth/token", httpContent).Result;

                var responseString = response.Content.ReadAsStringAsync();

                Auth = (AuthentificationResultDto)j.Deserialize(responseString.Result, typeof(AuthentificationResultDto));

                IsConnected = Auth.StatusId == 0;

                if (IsConnected)
                {
                    var domeCall = new DomeClient();
                    var account = domeCall.GetAccount(Auth.AccountId);
                    if (account.Succeeded && account.Entity.DOME_profileList.Length == 1)
                    {
                        MainProfilId = account.Entity.DOME_profileList[0].profileId;
                        domeCall._SelectProfil(MainProfilId.Value);
                    }
                }


            }
        }

        private static string CreateMd5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
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
