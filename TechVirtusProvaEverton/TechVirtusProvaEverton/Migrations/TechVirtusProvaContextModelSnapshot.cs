using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using TechVirtusProvaEverton.DAO;

namespace TechVirtusProvaEverton.Migrations
{
    [DbContext(typeof(TechVirtusProvaContext))]
    partial class TechVirtusProvaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TechVirtusProvaEverton.Models.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StatusAnalise");

                    b.Property<int?>("TransacaoId");

                    b.Property<int?>("UsuarioId");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TechVirtusProvaEverton.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cep");

                    b.Property<string>("Cnpj");

                    b.Property<string>("Fantasia");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Numero");

                    b.Property<string>("RazaoSocial");

                    b.Property<int?>("TipoServicoId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TechVirtusProvaEverton.Models.EmpresaContratada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EmpresaId");

                    b.Property<int?>("TransacaoId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TechVirtusProvaEverton.Models.EmpresaContratante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EmpresaId");

                    b.Property<int?>("TransacaoId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TechVirtusProvaEverton.Models.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TipoAcesso");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TechVirtusProvaEverton.Models.StatusTransacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Status");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TechVirtusProvaEverton.Models.TipoPessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Tipo");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TechVirtusProvaEverton.Models.TipoServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NomeServico");

                    b.Property<decimal>("ValorServico");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TechVirtusProvaEverton.Models.Transacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("ComprovantePdf");

                    b.Property<int?>("EmpresaContratadaId");

                    b.Property<int?>("EmpresaContratanteId");

                    b.Property<int?>("StatusTransacaoId");

                    b.Property<int?>("TipoServicoId");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TechVirtusProvaEverton.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cnpj");

                    b.Property<string>("Cpf");

                    b.Property<string>("Email");

                    b.Property<string>("Login");

                    b.Property<string>("Nome");

                    b.Property<int?>("PerfilId");

                    b.Property<string>("Senha");

                    b.Property<int?>("TipoPessoaId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TechVirtusProvaEverton.Models.Avaliacao", b =>
                {
                    b.HasOne("TechVirtusProvaEverton.Models.Transacao")
                        .WithMany()
                        .HasForeignKey("TransacaoId");

                    b.HasOne("TechVirtusProvaEverton.Models.Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("TechVirtusProvaEverton.Models.Empresa", b =>
                {
                    b.HasOne("TechVirtusProvaEverton.Models.TipoServico")
                        .WithMany()
                        .HasForeignKey("TipoServicoId");
                });

            modelBuilder.Entity("TechVirtusProvaEverton.Models.EmpresaContratada", b =>
                {
                    b.HasOne("TechVirtusProvaEverton.Models.Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId");
                });

            modelBuilder.Entity("TechVirtusProvaEverton.Models.EmpresaContratante", b =>
                {
                    b.HasOne("TechVirtusProvaEverton.Models.Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId");
                });

            modelBuilder.Entity("TechVirtusProvaEverton.Models.Transacao", b =>
                {
                    b.HasOne("TechVirtusProvaEverton.Models.EmpresaContratada")
                        .WithOne()
                        .HasForeignKey("TechVirtusProvaEverton.Models.Transacao", "EmpresaContratadaId");

                    b.HasOne("TechVirtusProvaEverton.Models.EmpresaContratante")
                        .WithOne()
                        .HasForeignKey("TechVirtusProvaEverton.Models.Transacao", "EmpresaContratanteId");

                    b.HasOne("TechVirtusProvaEverton.Models.StatusTransacao")
                        .WithMany()
                        .HasForeignKey("StatusTransacaoId");

                    b.HasOne("TechVirtusProvaEverton.Models.TipoServico")
                        .WithMany()
                        .HasForeignKey("TipoServicoId");

                    b.HasOne("TechVirtusProvaEverton.Models.Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("TechVirtusProvaEverton.Models.Usuario", b =>
                {
                    b.HasOne("TechVirtusProvaEverton.Models.Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilId");

                    b.HasOne("TechVirtusProvaEverton.Models.TipoPessoa")
                        .WithMany()
                        .HasForeignKey("TipoPessoaId");
                });
        }
    }
}
