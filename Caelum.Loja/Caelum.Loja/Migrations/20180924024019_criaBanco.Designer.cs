using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Lucas.Loja.Context;

namespace Caelum.Loja.Migrations
{
    [DbContext(typeof(ModelContext))]
    [Migration("20180924024019_criaBanco")]
    partial class criaBanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lucas.Loja.Model.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Secao");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("Lucas.Loja.Model.Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<double>("Preco");

                    b.Property<int>("ProdutoCategoriaID");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("Lucas.Loja.Model.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Password");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("Lucas.Loja.Model.Produto", b =>
                {
                    b.HasOne("Lucas.Loja.Model.Categoria")
                        .WithMany()
                        .HasForeignKey("ProdutoCategoriaID");
                });
        }
    }
}
