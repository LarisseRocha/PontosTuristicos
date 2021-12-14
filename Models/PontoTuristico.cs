using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteNewcon.Models
{
    [Table("PontoTuristico")]
    public class PontoTuristico
    {
        public int Id{get; set;}
        public string Descricao{get; set;}
        public Endereco Endereco{get; set;}
        public DateTime Datacriacao{get; set;}

        
    }
}