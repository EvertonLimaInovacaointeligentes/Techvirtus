using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechVirtusProvaEverton.Models;

namespace TechVirtusProvaEverton.DAO
{
    
    public class TipoPessoaDAO
    {
       
        public void Adicionar(TipoPessoa tipo)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.TipoPessoas.Add(tipo);
                context.SaveChanges();
            }
        }
        public void Atualizar(TipoPessoa tipo)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Entry(tipo).State = Microsoft.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public IList<TipoPessoa> Lista()
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.TipoPessoas.ToList();
            }
        }
        public TipoPessoa Busca(TipoPessoa tipo)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.TipoPessoas.FirstOrDefault(e => e.Tipo==tipo.Tipo);                               
            }
        }
        public TipoPessoa BuscarPorId(int id)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.TipoPessoas.FirstOrDefault(a => a.Id == id);

            }
        }
        public void Remover(TipoPessoa tipo)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.TipoPessoas.Remove(tipo);
                context.SaveChanges();
            }
        }
       
    }
}