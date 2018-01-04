using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapeamentoImagem.Classes
{
    public class Crianca
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string NomeMae { get; set; }
        public List<Pe> Pontos { get; set; } = new List<Pe>();
    }
}
