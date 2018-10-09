using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Caelum.Loja.Migrations
{
    public partial class Heranca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Produto_Categoria_ProdutoCategoriaID", table: "Produto");
            migrationBuilder.DropForeignKey(name: "FK_Venda_Usuario_UsuarioID", table: "Venda");
            migrationBuilder.DropForeignKey(name: "FK_VendaProduto_Produto_ProdutoID", table: "VendaProduto");
            migrationBuilder.DropForeignKey(name: "FK_VendaProduto_Venda_VendaID", table: "VendaProduto");
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Usuario",
                nullable: false,
                defaultValue: "");
            migrationBuilder.AddColumn<int>(
                name: "CPF",
                table: "Usuario",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "CNPJ",
                table: "Usuario",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_ProdutoCategoriaID",
                table: "Produto",
                column: "ProdutoCategoriaID",
                principalTable: "Categoria",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Usuario_UsuarioID",
                table: "Venda",
                column: "UsuarioID",
                principalTable: "Usuario",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_VendaProduto_Produto_ProdutoID",
                table: "VendaProduto",
                column: "ProdutoID",
                principalTable: "Produto",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_VendaProduto_Venda_VendaID",
                table: "VendaProduto",
                column: "VendaID",
                principalTable: "Venda",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Produto_Categoria_ProdutoCategoriaID", table: "Produto");
            migrationBuilder.DropForeignKey(name: "FK_Venda_Usuario_UsuarioID", table: "Venda");
            migrationBuilder.DropForeignKey(name: "FK_VendaProduto_Produto_ProdutoID", table: "VendaProduto");
            migrationBuilder.DropForeignKey(name: "FK_VendaProduto_Venda_VendaID", table: "VendaProduto");
            migrationBuilder.DropColumn(name: "Discriminator", table: "Usuario");
            migrationBuilder.DropColumn(name: "CPF", table: "Usuario");
            migrationBuilder.DropColumn(name: "CNPJ", table: "Usuario");
            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_ProdutoCategoriaID",
                table: "Produto",
                column: "ProdutoCategoriaID",
                principalTable: "Categoria",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Usuario_UsuarioID",
                table: "Venda",
                column: "UsuarioID",
                principalTable: "Usuario",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_VendaProduto_Produto_ProdutoID",
                table: "VendaProduto",
                column: "ProdutoID",
                principalTable: "Produto",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_VendaProduto_Venda_VendaID",
                table: "VendaProduto",
                column: "VendaID",
                principalTable: "Venda",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
