using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucas.Loja.Model
{
    public class VendaProduto
    {
        public int ID { get; set; }

        public Produto Produto { get; set; }

        public int ProdutoID { get; set; }

        public Venda Venda { get; set; }

        public int VendaID { get; set; } 
    }
}
