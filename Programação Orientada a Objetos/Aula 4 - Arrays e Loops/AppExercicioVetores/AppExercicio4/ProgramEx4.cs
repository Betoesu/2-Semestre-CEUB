Int32[] numerosImpares = new Int32[10];
Int32[] numerosPares = new Int32[10];
Int32 numero;


for  (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1}° número");
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero % 2 == 0)
    {
        numerosPares[i] = numero;
    }

    else if (numero % 2 != 0)
    {
        numerosImpares[i] = numero;
    }
}

Console.WriteLine("\nPares:\n");
for (int i = 0;i < 10; i++)
{   
    if (numerosPares[i] != 0)
    {
       Console.WriteLine(numerosPares[i]);
    }
    
}


Console.WriteLine("\nImpares:\n");
for (int i = 0; i < 10; i++)
{
    if (numerosImpares[i] != 0)
    {
        Console.WriteLine(numerosImpares[i]);
    }
    
}