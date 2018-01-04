using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapeamentoImagem.Classes
{
    public enum Lado
    {
        Direito, Esquerdo
    }

    public class Pe
    {
        public Guid Id { get; set; }
        public Lado Lado { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        // Navegacional
        public virtual Crianca Crianca { get; set; }
    }
}
