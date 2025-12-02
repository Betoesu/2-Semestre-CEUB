using Microsoft.AspNetCore.Mvc;

namespace WebApiOperadoresAritimeticos.Controllers
{
    
    public class Exercicio5Controller : Controller
    {
        [HttpGet("Aplicacao")]
        public string Aplicacao(double saldo)
        {
            double novoSaldo;

            novoSaldo = (saldo*1/100)+saldo;

            return $"Sua aplicação foi de {saldo} e após o reajuste de 1% foi para {novoSaldo}";
        }
    }
}
