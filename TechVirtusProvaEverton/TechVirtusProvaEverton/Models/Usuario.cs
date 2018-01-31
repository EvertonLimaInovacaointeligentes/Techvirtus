using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechVirtusProvaEverton.Models
{
    public class Usuario
    {
        public int Id{ get; set; }    
        public int? PerfilId { get; set; }
        public int? TipoPessoaId { get; set; }
                
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        [EmailAddress(ErrorMessage ="*E-mail invalido")]
        public string Email { get; set; }
        [Required(ErrorMessage ="*Campo Login Usuário é Obrigatório")]
        public string Login { get; set; }
        [Required(ErrorMessage ="*Campo Senha Usuário é Obrigatório")]
        public string Senha { get; set; }
        
        public virtual TipoPessoa TipoPessoa { get; set; }
        public virtual Perfil Perfil { get; set; }
        
       

    }
}