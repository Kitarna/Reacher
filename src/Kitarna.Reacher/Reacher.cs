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
    }
}