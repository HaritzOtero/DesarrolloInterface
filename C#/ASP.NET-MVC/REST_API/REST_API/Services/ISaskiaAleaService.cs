using REST_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace REST_API.Services
{
    public interface ISaskiaAleaService
    {
        Task<List<SaskiaAlea>> GetSaskiaAleak();
        Task<List<SaskiaAlea>> GetSaskiaAlea(string id);
        Task PutSaskiaAlea(SaskiaAlea saskiaAlea);
        Task PostSaskiaAlea(SaskiaAlea saskiaAlea);
        Task DeleteSaskiaAlea(SaskiaAlea saskiaAlea);
        bool SaskiaAleaExists(int id);
    }
}
