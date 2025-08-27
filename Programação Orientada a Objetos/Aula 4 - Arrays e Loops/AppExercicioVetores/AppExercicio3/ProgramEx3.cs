double[] valoresNumericos = new double[5];
double media = 0;

for (int i = 0; i < valoresNumericos.Length; i++)
{
    Console.WriteLine($"Escreva o {i + 1}° Valor: ");
    valoresNumericos[i] = Convert.ToDouble(Console.ReadLine());
    media += valoresNumericos[i] / valoresNumericos.Length;
}

Console.WriteLine(media);