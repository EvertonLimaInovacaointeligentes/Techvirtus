using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechVirtusProvaEverton.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public int? TransacaoId { get; set; } 
        public int? UsuarioId { get; set; }
        public decimal Valor { get; set; }
        public string StatusAnalise { get; set; }
        public virtual Transacao Transacao { get; set; }
        public virtual Usuario Usuario { get; set; }
        
    }
}