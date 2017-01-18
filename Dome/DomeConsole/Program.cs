using Dome;
using Dome.Authentification;
using System.ServiceModel;

namespace DomeConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //var binding = new BasicHttpBinding();
            //var endpoint = new EndpointAddress(@"http://159.122.2.36/oauth-soap/DOME_BUS_EAI_R001loginWS");
            //var client = new DOME_BUS_EAI_R001loginWSClient(binding, endpoint);

            //var result = client.login(new userInfoDto { username = "op.lab4", password = "5747a0021eb349e9c8d3667cf1a5e9ec" });


           // var a = DomeCall.GetProfileList(102);

            var b = new Entourage();
            b.getProfile();

            //var c = new MCP02();
            //c.createPerson();
        }
    }
}
