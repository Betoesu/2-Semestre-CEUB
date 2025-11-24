using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2Polimorfismo.model
{
    public class Animal
    {
        private string nome;
        private int numeroPatas;

        public string Nome { get => nome; set => nome = value; }
        public int NumeroPatas { get => numeroPatas; set => numeroPatas = value; }

        public virtual string EmitirSom()
        {
            return "Som do Animal";
        }
    }
}
