using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasseAbstrataBCC.Model
{
    public abstract class Personagem
    {
        public string Nome { get; set; }
        public Int32 Vida { get; set; }
        public Int32 Nivel { get; set; }

        public abstract void UsarHabilidade();
    }
}
