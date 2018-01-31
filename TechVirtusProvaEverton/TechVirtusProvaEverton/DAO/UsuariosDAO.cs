using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TechVirtusProvaEverton.Models;

namespace TechVirtusProvaEverton.DAO
{
    public class UsuariosDAO
    {
       
        public void Adicionar(Usuario usuario)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
                
            }
        }
        public void Atualiza(Usuario usuario)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Entry(usuario).State = Microsoft.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        
        public Usuario Busca(string login, string senha)
        {
            using (var context = new TechVirtusProvaContext())
            {                
                return context.Usuarios.FirstOrDefault(u => u.Login == login && u.Senha == senha);
            }
        }
        public IList<Usuario> Lista()
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.Usuarios.ToList();
                
            }
            
        }
        public Usuario BuscaPorId( int id)
        {
            using (var context = new TechVirtusProvaContext())
            {
                
                return context.Usuarios.FirstOrDefault(u => u.Id == id);
                
            }
        }
        public void Remover(Usuario usuario)
        {
            
                using (var context = new TechVirtusProvaContext())
                {             
                
                   context.Usuarios.Remove(usuario);
                    context.SaveChanges();
                }
            
        }
        
    }
}