using System.Linq;
using System.Threading.Tasks;
using TesteNewcon.Models;

namespace TesteNewcon.Interfaces
{
    public interface IPontoTuristico
    {
         Task <PontoTuristico> AddPontoTuristicoAsync(PontoTuristico model);
         Task <IQueryable<PontoTuristico>> GetTodosOsPontosAsync();
         
         
    }
}