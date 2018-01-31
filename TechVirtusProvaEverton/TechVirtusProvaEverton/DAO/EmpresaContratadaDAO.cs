using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechVirtusProvaEverton.Models;

namespace TechVirtusProvaEverton.DAO
{
    public class EmpresaContratadaDAO
    {
        
        public void Adicionar(EmpresaContratada contratada)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.EmpresaContratada.Add(contratada);
                context.SaveChanges();
            }
        }
        public void Atualizar(EmpresaContratada contratada)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Entry(contratada).State = Microsoft.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public IList<EmpresaContratada> Lista()
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.EmpresaContratada.ToList();
                 
            }
        }
        public EmpresaContratada Busca(EmpresaContratada contratada)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.EmpresaContratada.FirstOrDefault(e => e.Id==contratada.EmpresaId && e.TransacaoId==contratada.TransacaoId);
            }
        }
        public EmpresaContratada BuscarPorId(int id)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.EmpresaContratada.FirstOrDefault(a => a.Id == id);

            }
        }
        public void Remover(EmpresaContratada contratada)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.EmpresaContratada.Remove(contratada);
                context.SaveChanges();
            }
        }
        
    }
}