using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
                    using System.Reflection;

namespace Dome.DomeProxy.soap
{
    internal class DomeClientSoapCallHelper
    {
        public static T3 Call<T1, T2, T3>(Func<T1, T3> dataToReturn) where T2 : class where T1 : ClientBase<T2> where T3 : new()
        {

            var url = Settings.Urlbase + "/soap/" + typeof(T2).Name;
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(url);
            var client = (T1)Activator.CreateInstance(typeof(T1), new object[] { binding, endpoint });

            using (new OperationContextScope(client.InnerChannel))
            {
                HttpRequestMessageProperty request = new HttpRequestMessageProperty();
                request.Headers["Authorization"] = "Bearer " + AuthentificationHelper.token;

                OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = request;
                try
                {
                   return  dataToReturn(client);
                }
                catch (Exception)
                {
                    var error = new T3();

                    error.GetType().InvokeMember("statusId",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
                        Type.DefaultBinder, error, new object[]{1});
                    return error;
                }

            }
        }
    }
}
