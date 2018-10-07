using Lucas.Loja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucas.Loja.Model
{
    public class Venda
    {
        public int ID { get; set; }
        public int UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual List<VendaProduto> Produtos { get; set; }
    }
}
