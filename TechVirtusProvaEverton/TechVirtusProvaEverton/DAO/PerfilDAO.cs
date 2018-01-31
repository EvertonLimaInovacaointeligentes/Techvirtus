using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechVirtusProvaEverton.Models;

namespace TechVirtusProvaEverton.DAO
{
    public class PerfilDAO
    {
        
        public void Adicionar(Perfil perfil)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Perfil.Add(perfil);
                context.SaveChanges();
            }
        }
        public void Atualizar(Perfil perfil)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Entry(perfil).State = Microsoft.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public Perfil Busca(Perfil perfil)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.Perfil.FirstOrDefault(e => e.Id==perfil.Id && e.TipoAcesso==perfil.TipoAcesso);
            }
        }
        public Perfil BuscarPorId(int id)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.Perfil.FirstOrDefault(t => t.Id == id);
            }
        }
        public IList<Perfil> Lista()
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.Perfil.ToList();
            }
        }
        public void Remover(Perfil perfil)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Perfil.Remove(perfil);
                context.SaveChanges();
            }
        }
        
    }
}