Int32 numeroEstacao;


Console.WriteLine("Informe o número referente a estação você deseja: Primaveira(1), Verão(2), Outono(3), Inverno(4)");
numeroEstacao = Convert.ToInt32(Console.ReadLine());

switch (numeroEstacao)
{
    case 1:
        Console.WriteLine("Primaveira");
        break;
    case 2:
        Console.WriteLine("Verão");
        break;
    case 3:
        Console.WriteLine("Outono");
        break;
    case 4:
        Console.WriteLine("Inverno");
        break;
    default:
        Console.WriteLine("Informe o número referente a estação você deseja: Primaveira(1), Verão(2), Outono(3), Inverno(4)");
        break;
}
