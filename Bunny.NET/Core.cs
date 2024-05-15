using System;
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using Bunny.NET.Objets;
using Newtonsoft.Json;

namespace Bunny.NET
{
    public class Core
    {
        public static long PerPage = 10;

        private const string ApiServer = "https://api.bunny.net";

        public static async Task<string> SendGetRequest(string token, string url)
        {
            // Request
            using (RestClient restClient = new RestClient(ApiServer))
            {
                RestRequest restRequest = new RestRequest(url);
                restRequest.AddHeader("AccessKey", $"{token}");
                RestResponse response = await restClient.ExecuteAsync(restRequest);

                // Set
                string content = response.Content;
                HttpStatusCode httpStatusCode = response.StatusCode;

                // Switch
                switch (httpStatusCode)
                {
                    case HttpStatusCode.OK:
                        return content;

                    default:
                        Error error = JsonConvert.DeserializeObject<Error>(content);
                        throw new Exception($"{error.Message}");
                }
            }
        }
    }
}
