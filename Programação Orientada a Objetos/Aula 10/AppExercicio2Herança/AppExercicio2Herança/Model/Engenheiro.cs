using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicio2Herança.Model
{
    public class Engenheiro:Pessoa
    {
        private string crea;
        private string especialidade;

        public string Crea { get => crea; set => crea = value; }
        public string Especialidade { get => especialidade; set => especialidade = value; }
    }
}
