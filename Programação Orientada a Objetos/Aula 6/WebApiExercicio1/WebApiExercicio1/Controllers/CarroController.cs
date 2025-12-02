using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using WebApiExercicio1.Model;

namespace WebApiExercicio1.Controllers
{
    public class CarroController : Controller
    {
        [HttpGet("ImprimirDadosVeiculo")]
        public string ImprimirDadosVeiculo(string marcaCarro, string modeloCarro, string placaCarro, string corCarro,
        Int32 numeroMarchas, Int32 anoFabricacao, Int32 anoModeloCarro)

        {
            Carro carro = new Carro();
            carro.marca = marcaCarro;
            carro.modelo = modeloCarro;
            carro.placa = placaCarro;
            carro.cor = corCarro;
            carro.numeroMarchas = numeroMarchas;
            carro.anoFabricacao = anoFabricacao;
            carro.anoModelo = anoModeloCarro;

            return $"Marca: {carro.marca}\n\r" +
                    $"Modelo: {carro.modelo}\n\r" +
                    $"Placa: {carro.placa}\n\r" +
                    $"Cor: {carro.cor}\n\r";


        }

        [HttpGet("Buzinar")]
        public string Buzinar()
        {
            Carro carro = new Carro();
            return carro.Buzinar();
        }

        [HttpGet("LigarCarro")]

        public string LigarCarro()
        {
            string resultado;
            Carro carro = new Carro();

            if (carro.ligar)
            {
                resultado = "O carro já está ligado!!";
            }

            else
            {
                resultado = "O carro foi ligado!!!!";
            }
            return resultado;

        }
    }
}
