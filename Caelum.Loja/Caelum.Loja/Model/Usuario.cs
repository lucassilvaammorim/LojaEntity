using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucas.Loja.Model
{
    public abstract class Usuario
    {
        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Password { get; set; }
    }
}