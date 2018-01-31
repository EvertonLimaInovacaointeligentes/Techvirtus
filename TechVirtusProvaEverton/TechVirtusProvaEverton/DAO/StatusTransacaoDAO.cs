using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechVirtusProvaEverton.Models;

namespace TechVirtusProvaEverton.DAO
{
    
    public class StatusTransacaoDAO
    {
        
        public void Adicionar(StatusTransacao status)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.StatusTransacoes.Add(status);
                context.SaveChanges();
            }
        }
        public void Atuaizar(StatusTransacao  status)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Entry(status).State = Microsoft.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public StatusTransacao Busca(string status)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.StatusTransacoes.FirstOrDefault(s => s.Status == status);
                
            }
        }
        public StatusTransacao BuscarPorId(int id)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.StatusTransacoes.FirstOrDefault(s => s.Id == id);
            }
        }
        public IList<StatusTransacao>Lista()
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.StatusTransacoes.ToList();
            }
        }
        public void Remover(StatusTransacao status)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.StatusTransacoes.Remove(status);
                context.SaveChanges();
            }
        }
        
   
    }
}