using Microsoft.EntityFrameworkCore;
using TesteNewcon.Models;

namespace TesteNewcon.DataContext
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options){

        }

        public DbSet<PontoTuristico> PontoTuristico {get; set;}

        public DbSet<Endereco> Endereco{get; set;}
        
    }
}