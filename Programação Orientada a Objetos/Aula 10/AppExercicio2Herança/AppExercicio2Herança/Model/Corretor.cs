using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicio2Herança.Model
{
    public class Corretor:Pessoa
    {
        private string creci;

        public string Creci { get => creci; set => creci = value; }
    }
}
