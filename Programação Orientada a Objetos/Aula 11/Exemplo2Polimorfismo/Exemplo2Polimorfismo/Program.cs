using Exemplo2Polimorfismo.model;

string resultado = "";
string somAnimal = "";
Console.WriteLine($"Selecione o animal:");
Console.WriteLine("1 - Carneiro\n2 - Gato\n3 - Vaca");
Int32 numeroAnimal = Convert.ToInt32(Console.ReadLine());

switch (numeroAnimal)
{
    case 1:
        Carneiro carneiro = new Carneiro();
        Console.WriteLine("Informe o nome do animal.");
        carneiro.Nome = Console.ReadLine();
        carneiro.NumeroPatas = Convert.ToInt32(Console.ReadLine());
        resultado = $"O carneiro {carneiro.Nome} tem {carneiro.NumeroPatas} patas e faz {carneiro.EmitirSom()}";
        Console.WriteLine(resultado);

        break;

    case 2:
        Gato gato = new Gato();
        Console.WriteLine("Informe o nome do animal.");
        gato.Nome = Console.ReadLine();
        gato.NumeroPatas = Convert.ToInt32(Console.ReadLine());
        resultado = $"O gato {gato.Nome} tem {gato.NumeroPatas} patas e faz {gato.EmitirSom()}";
        Console.WriteLine(resultado);
        break;

    case 3:
        Vaca vaca = new Vaca();
        Console.WriteLine("Informe o nome do animal.");
        vaca.Nome = Console.ReadLine();
        vaca.NumeroPatas = Convert.ToInt32(Console.ReadLine());
        resultado = $"A vaca {vaca.Nome} tem {vaca.NumeroPatas} patas e faz {vaca.EmitirSom()}";
        Console.WriteLine(resultado);
        break;
    default:
        Console.WriteLine("Informe um número entre 1 e 3");
        break;

}