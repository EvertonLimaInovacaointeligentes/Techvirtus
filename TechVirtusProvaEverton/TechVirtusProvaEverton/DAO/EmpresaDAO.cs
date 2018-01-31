using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechVirtusProvaEverton.Models;

namespace TechVirtusProvaEverton.DAO
{
    
    public class EmpresaDAO
    {
      
        public void Adicionar(Empresa empresa)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Add(empresa);
                context.SaveChanges();
            }
        }
        public void Atualizar(Empresa empresa)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Entry(empresa).State = Microsoft.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }
        }
        public Empresa Busca(Empresa emp)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.Empresas.FirstOrDefault(e=>e.Logradouro == emp.Logradouro && e.Numero == emp.Numero &&
                            e.RazaoSocial == emp.RazaoSocial && e.Fantasia == emp.Fantasia);                            
                            
                
            }
        }
        public Empresa BuscaEmpresaId(int id)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.Empresas.FirstOrDefault(empresa => empresa.Id == id);
            }
        }
        public IList<Empresa> Lista()
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.Empresas.ToList();
            }
        }
        public void Remover(Empresa empresa)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Empresas.Remove(empresa);
                context.SaveChanges();
            }
        }
     
    }
}