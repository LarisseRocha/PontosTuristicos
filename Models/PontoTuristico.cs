using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteNewcon.Models
{
    [Table("PontoTuristico")]
    public class PontoTuristico
    {
        public int Id{get; set;}

        [StringLength(100, ErrorMessage = "A descricao nao pode ter mais de 100 caracteres.")]
        public string Descricao{get; set;}
        public virtual Endereco Endereco{get; set;}
        public DateTime Datacriacao{get; set;}

        
    }
}