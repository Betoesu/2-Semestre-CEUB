using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicio2Herança.Model
{
    public class Professor:Pessoa
    {
        private string nivel;
        private string materia;
        private string especialidade;
        private string matricula;

        public string Nivel { get => nivel; set => nivel = value; }
        public string Materia { get => materia; set => materia = value; }
        public string Especialidade { get => especialidade; set => especialidade = value; }
        public string Matricula { get => matricula; set => matricula = value; }
    }
}
