using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Lucas.Loja.Context;

namespace Caelum.Loja.Migrations
{
    [DbContext(typeof(ModelContext))]
    [Migration("20181009022704_Heranca")]
    partial class Heranca
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

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Nome");

                    b.Property<string>("Password");

                    b.HasKey("ID");

                    b.HasAnnotation("Relational:DiscriminatorProperty", "Discriminator");

                    b.HasAnnotation("Relational:DiscriminatorValue", "Usuario");
                });

            modelBuilder.Entity("Lucas.Loja.Model.Venda", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UsuarioID");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("Lucas.Loja.Model.VendaProduto", b =>
                {
                    b.Property<int>("ProdutoID");

                    b.Property<int>("VendaID");

                    b.Property<int>("ID");

                    b.HasKey("ProdutoID", "VendaID");
                });

            modelBuilder.Entity("Lucas.Loja.Model.PessoaFisica", b =>
                {
                    b.HasBaseType("Lucas.Loja.Model.Usuario");

                    b.Property<int>("CPF");

                    b.HasAnnotation("Relational:DiscriminatorValue", "PessoaFisica");
                });

            modelBuilder.Entity("Lucas.Loja.Model.PessoaJuridica", b =>
                {
                    b.HasBaseType("Lucas.Loja.Model.Usuario");

                    b.Property<int>("CNPJ");

                    b.HasAnnotation("Relational:DiscriminatorValue", "PessoaJuridica");
                });

            modelBuilder.Entity("Lucas.Loja.Model.Produto", b =>
                {
                    b.HasOne("Lucas.Loja.Model.Categoria")
                        .WithMany()
                        .HasForeignKey("ProdutoCategoriaID");
                });

            modelBuilder.Entity("Lucas.Loja.Model.Venda", b =>
                {
                    b.HasOne("Lucas.Loja.Model.Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID");
                });

            modelBuilder.Entity("Lucas.Loja.Model.VendaProduto", b =>
                {
                    b.HasOne("Lucas.Loja.Model.Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID");

                    b.HasOne("Lucas.Loja.Model.Venda")
                        .WithMany()
                        .HasForeignKey("VendaID");
                });
        }
    }
}
