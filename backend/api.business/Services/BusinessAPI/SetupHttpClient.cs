using BusinessAPI.ApiClients;
using Utils.Extensions;

namespace BusinessAPI
{
    public class SetupHttpClient
    {



        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public static void InitialService(WebApplicationBuilder builder)
        {



            builder.Services.AddTransient<MicroservicesHandler>();

            builder.Services.AddHttpClient<ISmsApiClients, SmsApiClients>(client =>
            {
                client.BaseAddress = new Uri(builder.Configuration["ApiClients:SMSApi"]);
                client.Timeout = TimeSpan.FromSeconds(30);
            });

        }
    }
}
