using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppExercicio1ClasseAlugaFacil.Model
{
    public class Cliente
    {
        public int idCliente;
        public string cpf;
        public string nome;
        public string cnh;

        public string ImprimirCliente()
        {
            string resultado;
            resultado = $"{nome},{cpf},{cnh}";
            return resultado;
        }
    }
}
