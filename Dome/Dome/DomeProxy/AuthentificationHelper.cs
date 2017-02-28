using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Script.Serialization;
using Dome.Client;
using Dome.Enum;

namespace Dome.DomeProxy
{
    internal class AuthentificationHelper
    {

        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public class DomeHeader
        {
            public string version { get; set; }
            public DateTime date
            {
                get
                {
                    return new DateTimeOffset(DateTime.Now.Ticks, TimeSpan.Zero).DateTime;
                }

            }
        }

        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public class AuthentificationResultDto
        {
            public int? statusId { get; set; }
            public string token { get; set; }
            public string statusUserMessage { get; set; }
            public string statusErrorMessage { get; set; }
            public string refresh_token { get; set; }
            public DomeHeader DOME_header { get; set; }
            public int? expires_in { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
            public int accountId { get; set; }
        }


        private static AuthentificationHelper _instance;


        public static Boolean IsConnected => Auth != null && string.IsNullOrWhiteSpace(Auth.token) == false;

        private static AuthentificationResultDto Auth { get; set; }

        public static string token => Auth.token;
        public static DateTime date => Auth.DOME_header.date;
        public static string version => Auth.DOME_header.version;

        public static int OperateurProfilId { get; set; }
        public static int StructureProfilId { get; set; }

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

        public static string Url { get; set; }
        public static void Connect(string username, string password, string url)
        {
            Url = url;

            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                       { "username", username },
                       { "rememberMe", "false" },
                       { "password", CreateMd5(password).ToLower() }
                };

                var j = new JavaScriptSerializer();
                var httpContent = new StringContent(j.Serialize(values), Encoding.UTF8, "application/json");

                var response = client.PostAsync(url + "oauth/token", httpContent).Result;

                var responseString = response.Content.ReadAsStringAsync();

                Auth = (AuthentificationResultDto)j.Deserialize(responseString.Result, typeof(AuthentificationResultDto));

               if (IsConnected)
                {
                    var domeCall = new DomeClient(username,password,url);
                    var account = domeCall.GetAccount(Auth.accountId);
                    if (account.Succeeded && account.Entity.DOME_profileList.Length == 1)
                    {
                        var operateurStructure =
                            account.Entity.DOME_profileList.Single(
                                profile => profile.typeProfileConstanteId == (int)Profile.OperateurStructure);

                        OperateurProfilId = operateurStructure.profileId;
                        StructureProfilId = operateurStructure.parentProfileId;
                        Url = url;

                        domeCall._SelectProfil(OperateurProfilId);
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
