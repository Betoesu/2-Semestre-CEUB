using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicio2ContaCorrente.model
{
    public class ContaCorrente
    {
        public Int32 numeroConta;
        public string nomeBanco;
        public string nomeAgencia;
        public string nomeCliente;

        public string Imprimir()
        {
            string resultado;
            resultado = $"{numeroConta}, {nomeBanco}, {nomeCliente}, {nomeAgencia}";
            return resultado;
        }
    }
}
