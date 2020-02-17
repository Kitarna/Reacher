using Kitarna.Reacher.Models;
using Kitarna.Reacher.Services;
using System.Net.Http;

namespace Kitarna.Reacher
{
    public class Reacher
    {
        private readonly HttpClient _client;

        public Reacher(HttpClient client)
        {
            _client = client;
        }

        public void Get(Request request)
        {
            var requestService = new RequestService();
            requestService.Get(request);
        }
    }
}