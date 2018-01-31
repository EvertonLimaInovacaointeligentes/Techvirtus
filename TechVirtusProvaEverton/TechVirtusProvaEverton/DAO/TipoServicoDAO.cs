using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechVirtusProvaEverton.Models;

namespace TechVirtusProvaEverton.DAO
{
    
    public class TipoServicoDAO
    {
       
        public void Adicionar(TipoServico tipo)
        {
            using (var context = new TechVirtusProvaContext())
            { 
                context.TipoServicos.Add(tipo);
                context.SaveChanges();
            }
        }
        public void Atualizar(TipoServico tipo)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Entry(tipo).State = Microsoft.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public TipoServico Busca(TipoServico tipo)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.TipoServicos.FirstOrDefault(e => e.Id == tipo.Id && e.NomeServico == tipo.NomeServico && e.ValorServico == tipo.ValorServico);                                
            }
        }
        public TipoServico BuscarPorId(int id)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.TipoServicos.FirstOrDefault(t => t.Id == id);
            }
        }
        public IList<TipoServico> Lista()
        {
            using (var context = new TechVirtusProvaContext())
            {
                
                return context.TipoServicos.ToList();
                
            }
        }
        public void Remover(TipoServico servico)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.TipoServicos.Remove(servico);
                context.SaveChanges();
            }
        }
        
    }
}