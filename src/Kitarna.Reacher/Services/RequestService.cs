using System.Net.Http;
using System.Threading.Tasks;
using Kitarna.Reacher.Models;

namespace Kitarna.Reacher.Services
{
    public class RequestService
    {
        /// <summary>
        /// Sends a GET request for the supplied values in the Request Model
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Response Get(Request request)
        {
            Response response = new Response();
            using (var client = new HttpClient())
            {
                if (request.Headers != null)
                {
                    foreach (var header in request.Headers)
                    {
                        client.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                }

                HttpResponseMessage content = client.GetAsync(request.URL).Result;

                if (content.IsSuccessStatusCode)
                {
                    response.StatusCode = content.StatusCode;
                    response.Headers = content.Headers;
                    response.Body = content.Content.ReadAsStringAsync().Result;
                }
            }

            return response;
        }

        /// <summary>
        /// Sends a POST request for the supplied values in the request Model
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Response Post(Request request)
        {
            using (var client = new HttpClient())
            {

            }

            return new Response();
        }
    }
}