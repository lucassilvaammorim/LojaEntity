using Caelum.Loja.Persistense;
using Lucas.Loja.Model;
using Lucas.Loja.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioDAO daoUsuario = new UsuarioDAO();
            ProdutoDAO produtoDAO = new ProdutoDAO();
            CategoriaDAO categoriaDAO = new CategoriaDAO();
            
            Usuario usuario1 = new Usuario()
            {
                Nome = "Lucas",
                Password = "1233"                
            };
            Usuario usuario2 = new Usuario()
            {
                Nome = "Lucas",
                Password = "1233"
            };
            Usuario usuario3 = new Usuario()
            {
                Nome = "Lucas",
                Password = "1233"
            };
            daoUsuario.Insert(usuario1);
            daoUsuario.Insert(usuario2);
            daoUsuario.Insert(usuario3);

            Categoria categoria = new Categoria()
            {
                Nome="Informática",
                Secao = "B"
            };
            Produto produto = new Produto()
            {
                Nome = "Mouse",
                Preco = 30.20,
                ProdutoCategoria = categoria
            };
            categoriaDAO.Insert(categoria);
            produtoDAO.Insert(produto);

        }
    }
}
