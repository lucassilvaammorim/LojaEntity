using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucas.Loja.Model
{
    public class Produto
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set;}
        public double Preco { get; set; }
        public virtual Categoria ProdutoCategoria { get; set; }

        [ForeignKey("ProdutoCategoria")]
        public int ProdutoCategoriaID { get; set; }

        public virtual List<VendaProduto> Vendas { get; set; }

    }
}
