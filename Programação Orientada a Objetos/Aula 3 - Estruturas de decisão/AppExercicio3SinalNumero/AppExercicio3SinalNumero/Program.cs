Int32 numero;
string resultado;

Console.WriteLine("Digite seu número: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine($"O número {numero} é Positivo");
}

else if (numero < 0)
{
    Console.WriteLine($"O número {numero} é Negativo");
}
else 
{
    Console.WriteLine($"O número {numero} é nulo");
}