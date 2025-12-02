using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicio2Herança.Model
{
    public class Bombeiro:Pessoa
    {
        private string matricula;
        private string arma;
        private DateTime dataIngresso;

        public string Matricula { get => matricula; set => matricula = value; }
        public string Arma { get => arma; set => arma = value; }
        public DateTime DataIngresso { get => dataIngresso; set => dataIngresso = value; }
    }
}
