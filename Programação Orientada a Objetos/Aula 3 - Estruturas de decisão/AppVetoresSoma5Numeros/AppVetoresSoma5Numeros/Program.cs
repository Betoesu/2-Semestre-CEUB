Int32[] numeros = new Int32[5];
Int32 soma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Informe {i+1}° o número");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
    soma += numeros[i];
}
Console.WriteLine(soma);