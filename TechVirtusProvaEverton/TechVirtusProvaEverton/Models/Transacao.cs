using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace TechVirtusProvaEverton.Models
{
    public class Transacao
    {
        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        [Required(ErrorMessage = "*Campo Empresa Contatada Obrigatório")]
        public int? EmpresaContratadaId { get; set; }
        [Required(ErrorMessage = "*Campo Empresa Contatante Obrigatório")]
        public int? EmpresaContratanteId { get; set; }
        [Required(ErrorMessage = "*Campo Servico Obrigatório")]
        public int? TipoServicoId { get; set; }
        
        public int? StatusTransacaoId { get; set; }
        [Required(ErrorMessage = "*Campo Compravante Anexo Pdf Obrigatório")]
        public byte[] ComprovantePdf { get; set; }
        public virtual EmpresaContratada EmpresaContratada { get; set; }
        public virtual EmpresaContratante EmpresaContratante { get; set; }
        public virtual TipoServico TipoServico { get; set; }
        public virtual StatusTransacao StatusTransacao { get; set; }
        public virtual Usuario Usuario { get; set; }
        
    }
}