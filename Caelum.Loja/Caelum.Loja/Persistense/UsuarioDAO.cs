using Lucas.Loja.Context;
using Lucas.Loja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucas.Loja.Persistence
{
    public class UsuarioDAO
    {
        ModelContext contexto;
        public UsuarioDAO()
        {
            contexto = new ModelContext();

        }

        public Usuario GetById(int id)
        {
            try
            {
                var user = contexto.Usuarios.FirstOrDefault(u => u.ID == id);
                return user;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }

        public void Insert(Usuario usuario)
        {
            try
            {
                contexto.Usuarios.Add(usuario);
                contexto.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
     
        }

        public void Update(Usuario usuario)
        {
            try
            {
                contexto.Usuarios.Update(usuario);
                contexto.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            
        }

        public void Delete(Usuario usuario)
        {
            try
            {
                contexto.Usuarios.Remove(usuario);
                contexto.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
