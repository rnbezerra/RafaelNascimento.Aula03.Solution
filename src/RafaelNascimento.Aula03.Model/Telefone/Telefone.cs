using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafaelNascimento.Aula03.Model
{
    public class Telefone
    {
        public int Id { get; set; }
        public String DDD { get; set; }
        public String Numero { get; set; }
        public TipoTelefone Tipo { get; set; }
    }
}
