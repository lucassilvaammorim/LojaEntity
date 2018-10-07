using Lucas.Loja.Context;
using Lucas.Loja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucas.Loja.Persistense
{
    public class VendaDAO
    {
        private ModelContext contexto;

        public VendaDAO()
        {
            contexto = new ModelContext();
        }

        public List<Venda> GetById(int id)
        {
            return contexto.Vendas.Where(v => v.ID == id).ToList();
        }

        public List<Venda> GetAll()
        {
            return contexto.Vendas.ToList();
        }

        public List<Venda> GetByUsuario(Usuario usuario)
        {
            return contexto.Vendas.Where(v => v.Usuario.Equals(usuario)).ToList();
        }

        public void Insert(Usuario usuario, Produto produto)
        {
            try
            {
                contexto.VendaProduto.Add(new VendaProduto()
                {
                    Produto = produto,
                    Venda = new Venda()
                    {
                        Usuario = usuario
                    }

                });

                contexto.SaveChanges();
            }
            catch(Exception Ex)
            {
                throw new Exception(Ex.ToString());
            }
        }
    }
}
