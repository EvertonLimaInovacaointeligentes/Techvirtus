using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechVirtusProvaEverton.Models
{
    public class TipoServico
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="*Campo Nome Serviço Obrigatório")]        
        public string NomeServico { get; set; }
        [Required(ErrorMessage ="*Campo Valor do Serviço Obrigatório")]          
        public decimal ValorServico { get; set; }
    }
}