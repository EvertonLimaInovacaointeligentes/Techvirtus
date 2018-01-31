using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechVirtusProvaEverton.Models;

namespace TechVirtusProvaEverton.DAO
{
    public class EmpresaContratanteDAO
    {
        
        public void Adicionar(EmpresaContratante contratante)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Add(contratante);
                context.SaveChanges();
            }
        }
        public void Atualizar(EmpresaContratante contratante)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Entry(contratante).State = Microsoft.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public IList<EmpresaContratante> Lista()
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.EmpresaContratante.ToList();

            }
        }
        public EmpresaContratante Busca(EmpresaContratante contratada)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.EmpresaContratante.FirstOrDefault(e => e.Id == contratada.EmpresaId && e.TransacaoId == contratada.TransacaoId);
            }
        }
        public EmpresaContratante BuscarPorId(int id)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.EmpresaContratante.FirstOrDefault(a => a.Id == id);

            }
        }
        public void Remover(EmpresaContratante contratada)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.EmpresaContratante.Remove(contratada);
                context.SaveChanges();
            }
        }
       
    }
}