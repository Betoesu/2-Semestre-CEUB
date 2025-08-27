using Microsoft.AspNetCore.Mvc;

namespace WebApiOperadoresAritimeticos.Controllers
{
    public class Exercicio6Controller : Controller
    {
        [HttpGet("AreaTrapezio")]
        public string AreaTrapezio(double baseMaior, double baseMenor, double altura)
        {
            double areaTrapezio;

            areaTrapezio = ((baseMaior+baseMenor)*altura)/2;
            return $"Área do Trapézio: {areaTrapezio}";
        }
    }
}
