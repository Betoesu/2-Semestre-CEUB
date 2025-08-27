using Microsoft.AspNetCore.Mvc;

namespace WebApiOperadoresAritimeticos.Controllers
{
    public class Exercicio4Controller : Controller
    {
        [HttpGet("Media1Semestre")]
        public string Media1Semestre(double prova1, double prova2, double prova3, double prova4)
        {
            double mediaQuatroNotas;

            mediaQuatroNotas = (prova1 + prova2 + prova3 + prova4)/4;
          
            return $"A sua média do 1° Semestre é {mediaQuatroNotas}";
        }
    }
}
