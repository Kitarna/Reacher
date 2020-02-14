using System.Threading.Tasks;
using Kitarna.Reacher.Models;

namespace Kitarna.Reacher.Services
{
    public interface IRequestService
    {
         Task<Request> Get(Request request);
         Task<Request> Post(Request request);
    }
}