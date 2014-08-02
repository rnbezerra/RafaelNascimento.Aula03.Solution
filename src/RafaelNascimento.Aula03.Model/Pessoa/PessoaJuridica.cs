using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafaelNascimento.Aula03.Model
{
    public class PessoaJuridica : Pessoa
    {
        public String CNPJ { get; set; }
        public String Nome { get; set; }
        public String NomeFantasia { get; set; }
        public String InscricaoEstadual { get; set; }
    }
}
