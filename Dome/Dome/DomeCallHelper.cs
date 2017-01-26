using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Dome
{
    public class DomeCallHelper
    {
        public static T3 call2<T1, T2, T3>(Func<T1, T3> test) where T2 : class where T1 : ClientBase<T2>
        {

            var url = settings.urlbase + "/soap/" + typeof(T2).Name;
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(url);
            var client = (T1)Activator.CreateInstance(typeof(T1), new object[] { binding, endpoint });

            using (new OperationContextScope(client.InnerChannel))
            {
                HttpRequestMessageProperty request = new HttpRequestMessageProperty();
                request.Headers["Authorization"] = "Bearer " + AuthentificationHelper.Instance.auth.token;

                OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = request;
                var data = test(client);
                return data;
            }
        }
    }
}
