using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using TechVirtusProvaEverton.DAO;

namespace TechVirtusProvaEverton.Migrations
{
    [DbContext(typeof(TechVirtusProvaContext))]
    [Migration("20170821015207_CriaUsuario")]
    partial class CriaUsuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
