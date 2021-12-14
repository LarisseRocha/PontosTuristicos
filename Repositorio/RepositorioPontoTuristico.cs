using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IQueryable<PontoTuristico>> GetTodosOsPontosAsync()
            {
                var listaPontosTur = await _dataContext.PontoTuristico.ToListAsync();

                IQueryable<PontoTuristico> query = _dataContext.PontoTuristico;

                query = query.AsNoTracking().OrderByDescending(p => p.Datacriacao);                

                return query;

            }
    }
}