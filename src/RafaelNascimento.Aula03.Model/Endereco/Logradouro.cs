using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafaelNascimento.Aula03.Model
{
    public class Logradouro
    {
        public int Id { get; set; }
        public String NomeLogradouro { get; set; }
        public TipoLogradouro Tipo { get; set; }
        public int IdBairro { get; set; }


        
    }
}
