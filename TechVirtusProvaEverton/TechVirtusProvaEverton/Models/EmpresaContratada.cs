using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechVirtusProvaEverton.Models
{
    public class EmpresaContratada
    {
        public int Id { get; set; }
        public int? EmpresaId{get;set;}
        
        public int? TransacaoId { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Transacao Transacao { get; set; }

    }
}