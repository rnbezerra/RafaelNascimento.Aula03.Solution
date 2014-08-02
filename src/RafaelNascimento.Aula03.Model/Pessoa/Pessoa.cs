using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafaelNascimento.Aula03.Model
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public String Email { get; set; }
        public int IdTelefone { get; set; }
        public int IdEndereco { get; set; }
    }
}
