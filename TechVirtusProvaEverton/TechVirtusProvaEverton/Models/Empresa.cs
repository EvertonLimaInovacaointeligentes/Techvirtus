using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechVirtusProvaEverton.Models
{
    public class Empresa
    {
        
        public int Id { get; set; }
        public int? TipoServicoId { get; set; }        
        [Required(ErrorMessage = "*Campo CNPJ é Obrigatório")]
        public string Cnpj { get; set; }
        [Required(ErrorMessage = "*Campo Nome Fantasia é Obrigatório")]
        public string Fantasia { get; set; }
        [Required(ErrorMessage = "*Campo Razao Social é Obrigatório")]
        public string RazaoSocial { get; set; }
        [Required(ErrorMessage = "*Campo Logradouro é Obrigatório")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "*Campo Numero é Obrigatório")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "*Campo Cep é Obrigatório")]
        public string Cep { get; set; }
        
        public virtual TipoServico TipoServico { get; set; }
       
        
    }
}