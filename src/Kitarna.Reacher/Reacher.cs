using Kitarna.Reacher.Models;
using Kitarna.Reacher.Services;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kitarna.Reacher
{
    public class Reacher
    {
        public Response Get(Request request)
        {
            var requestService = new RequestService();
            
            Response response = requestService.Get(request);

            return response;
        }
    }
}