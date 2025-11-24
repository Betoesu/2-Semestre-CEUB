using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2Polimorfismo.model
{
    public class Gato:Animal
    {
        public override string EmitirSom()
        {
            return "MIAAAAAAAAU";
        }
    }
}
