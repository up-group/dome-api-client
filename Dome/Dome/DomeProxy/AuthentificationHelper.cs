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
    public class AuthentificationHelper
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

        private AuthentificationHelper() { }

        public Boolean IsConnected { get; set; }
        public AuthentificationResultDto Auth { get; set; }
        public int? OperateurProfilId { get; set; }
        public int? StructureProfilId { get; set; }

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

                IsConnected = Auth.statusId == 0;

                if (IsConnected)
                {
                    var domeCall = new DomeClient();
                    var account = domeCall.GetAccount(Auth.accountId);
                    if (account.Succeeded && account.Entity.DOME_profileList.Length == 1)
                    {
                        var operateurStructure =
                            account.Entity.DOME_profileList.Single(
                                profile => profile.typeProfileConstanteId == (int) Profile.OperateurStructure);

                        OperateurProfilId = operateurStructure.profileId;
                        StructureProfilId = operateurStructure.parentProfileId;


                        domeCall._SelectProfil(OperateurProfilId.Value);
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
