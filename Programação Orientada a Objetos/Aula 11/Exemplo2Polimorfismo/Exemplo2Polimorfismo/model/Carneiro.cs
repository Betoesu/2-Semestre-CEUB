using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2Polimorfismo.model
{
    public class Carneiro:Animal
    {
        public override string EmitirSom()
        {
            return "Meeeeeeeeeeeeeee!";
        }
    }
}
