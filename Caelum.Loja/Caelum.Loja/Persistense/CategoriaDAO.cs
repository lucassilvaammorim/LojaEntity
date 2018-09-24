using Lucas.Loja.Context;
using Lucas.Loja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Loja.Persistense
{
    public class CategoriaDAO
    {
        ModelContext contexo;

        public CategoriaDAO()
        {
            contexo = new ModelContext();
        }
        public List<Categoria> GetAll()
        {
            try
            {
                return contexo.Categorias.ToList();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Categoria GetById(int id)
        {
            try
            {
                return contexo.Categorias.First(c => c.ID == id);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    
        public void Delete(Categoria categoria)
        {
            try
            {
                contexo.Categorias.Remove(categoria);
                contexo.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void Insert(Categoria categoria)
        {
            try
            {
                contexo.Categorias.Add(categoria);
                contexo.SaveChanges();

            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
