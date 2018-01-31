using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechVirtusProvaEverton.Models;

namespace TechVirtusProvaEverton.DAO
{
    
    public class TransacaoDAO
    {
        
       
        public void Adicionar(Transacao transacao)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Transacoes.Add(transacao);
                context.SaveChanges();
            }

        }
        public void Atualizar(Transacao trasacao)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Entry(trasacao).State = Microsoft.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public Transacao Busca(Transacao trasacao)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.Transacoes.FirstOrDefault(e => e.Id == trasacao.Id && e.EmpresaContratadaId == trasacao.EmpresaContratadaId &&
                            e.EmpresaContratanteId == trasacao.EmpresaContratanteId && e.StatusTransacaoId == trasacao.StatusTransacaoId
                            && e.TipoServicoId == trasacao.TipoServicoId);                                
            }
        }
        public Transacao BuscarPorId(int id)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.Transacoes.FirstOrDefault(t=>t.Id==id);
            }
        }
        public IList<Transacao> Lista()
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.Transacoes.ToList();
            }
        }
        public void Remover(Transacao transacao)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Transacoes.Remove(transacao);
                context.SaveChanges();
            }

        }
        
    }
}