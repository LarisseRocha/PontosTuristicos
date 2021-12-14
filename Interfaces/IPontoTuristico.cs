using System.Collections.Generic;
using System.Threading.Tasks;
using TesteNewcon.Models;

namespace TesteNewcon.Interfaces
{
    public interface IPontoTuristico
    {
         Task <PontoTuristico> AddPontoTuristicoAsync(PontoTuristico model);
         Task <ICollection<PontoTuristico>> GetTodosOsPontosAsync();
         
         
    }
}