using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using TechVirtusProvaEverton.DAO;

namespace TechVirtusProvaEverton.Migrations
{
    [DbContext(typeof(TechVirtusProvaContext))]
    [Migration("20170821014234_CriaTipoSerivos")]
    partial class CriaTipoSerivos
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

            modelBuilder.Entity("TechVirtusProvaEverton.Models.TipoServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NomeServico");

                    b.Property<decimal>("ValorServico");

                    b.HasKey("Id");
                });
        }
    }
}
