using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucas.Loja.Model
{
    public class PessoaJuridica: Usuario
    {
        public int CNPJ { get; set; }
    }
}
