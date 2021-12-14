using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesteNewcon.Interfaces;
using TesteNewcon.Models;

namespace TesteNewcon.Data.Repositorio{


    public class RepositorioPontoTuristico : IPontoTuristico
    {

            public readonly DataContext _dataContext;
            public RepositorioPontoTuristico(DataContext dataContext){

                _dataContext = dataContext;
            }
            public async Task<PontoTuristico> AddPontoTuristicoAsync(PontoTuristico model)
            {
                await _dataContext.AddAsync(model);
                _dataContext.SaveChanges();
                return model;
            }

            public async Task<ICollection<PontoTuristico>> GetTodosOsPontosAsync()
            {
                var listaPontosTur = await _dataContext.PontoTuristico.ToListAsync();
                return listaPontosTur;
            }
    }
}