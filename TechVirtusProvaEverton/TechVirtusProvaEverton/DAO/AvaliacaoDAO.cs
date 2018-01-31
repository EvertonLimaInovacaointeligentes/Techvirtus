using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechVirtusProvaEverton.Models;

namespace TechVirtusProvaEverton.DAO
{
    public class AvaliacaoDAO
    {
        
        public void Adicionar(Avaliacao avaliacao)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Avaliacoes.Add(avaliacao);
                context.SaveChanges();
            }
        }
        public void Atualizar(Avaliacao avaliacao)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Entry(avaliacao).State = Microsoft.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public Avaliacao Busca(Avaliacao avaliacao)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.Avaliacoes.FirstOrDefault(e => e.Id == avaliacao.Id && e.StatusAnalise==avaliacao.StatusAnalise&&e.TransacaoId==avaliacao.TransacaoId && e.UsuarioId==avaliacao.UsuarioId && e.Valor==avaliacao.Valor);
            }
        }
        public Avaliacao BuscarPorId(int id)
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.Avaliacoes.FirstOrDefault(t => t.Id == id);
            }
        }
        public IList<Avaliacao> Lista()
        {
            using (var context = new TechVirtusProvaContext())
            {
                return context.Avaliacoes.ToList();
            }
        }
        public void Remover(Avaliacao avaliacao)
        {
            using (var context = new TechVirtusProvaContext())
            {
                context.Avaliacoes.Remove(avaliacao);
                context.SaveChanges();
            }
        }
        
    }
}