using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucas.Loja.Model
{
    public class Categoria
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set;}
        public string Secao { get; set;}
        public virtual List<Produto> Produtos { get; set; }
        
    }
}
