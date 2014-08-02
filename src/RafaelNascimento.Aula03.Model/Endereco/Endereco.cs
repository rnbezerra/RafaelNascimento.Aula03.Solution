using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafaelNascimento.Aula03.Model
{
    public class Endereco
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public String Complemento { get; set; }
        public TipoEndereco Tipo { get; set; }
        public int IdLogradouro { get; set; }


    }
}
