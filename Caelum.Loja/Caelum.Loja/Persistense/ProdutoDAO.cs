using Lucas.Loja.Context;
using Lucas.Loja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Loja.Persistense
{
    public class ProdutoDAO
    {
        ModelContext context;

        public ProdutoDAO()
        {
            context = new ModelContext();
        }
        public List<Produto> GetAll()
        {
            return context.Produtos.ToList();
        }
        public Produto GetById(int id)
        {
            return context.Produtos.First(p => p.ID == id);
        }
        public void Insert(Produto produto)
        {
            context.Produtos.Add(produto);
            context.SaveChanges();
        }
        public void Update(Produto produto)
        {
            context.Produtos.Update(produto);
            context.SaveChanges();
        }
        public void Delete(Produto produto)
        {
            context.Produtos.Remove(produto);
            context.SaveChanges();
        }

    }
}
