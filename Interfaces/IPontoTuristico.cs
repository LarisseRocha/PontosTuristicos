using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteNewcon.Models;

namespace TesteNewcon.Interfaces
{
    public interface IPontoTuristico
    {
         Task <PontoTuristico> AddPontoTuristicoAsync(PontoTuristico model);
         Task <IQueryable<PontoTuristico>> GetTodosOsPontosAsync();
         Task <IList<PontoTuristico>> GetPontoTuristicoPagAsync(int skip, int take);

         //Task<IList<Todo>> PaginatedGetAllTodosAsync(int skip, int take);
         
    }
}