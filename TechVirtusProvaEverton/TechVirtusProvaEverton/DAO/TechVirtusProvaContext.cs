using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Data.Entity;
using System.Configuration;
using TechVirtusProvaEverton.Models;

namespace TechVirtusProvaEverton.DAO
{
    public class TechVirtusProvaContext : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<TipoServico> TipoServicos { get; set; }
        public DbSet<TipoPessoa> TipoPessoas { get; set; }        
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<EmpresaContratada> EmpresaContratada { get; set; }
        public DbSet<EmpresaContratante> EmpresaContratante { get; set; }
        public DbSet<StatusTransacao> StatusTransacoes { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }        
        public DbSet<Avaliacao> Avaliacoes { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            string caminho = ConfigurationManager.ConnectionStrings["VirtusProvaEvertonConnectionString"].ConnectionString;
            optionBuilder.UseSqlServer(caminho);
            base.OnConfiguring(optionBuilder);
        }
        
    }
}