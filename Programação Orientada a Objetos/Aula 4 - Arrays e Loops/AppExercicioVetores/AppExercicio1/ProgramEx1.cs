double[] salarios = new double[10];
double maiorSalario;

for (int i = 0; i < salarios.Length; i++)
{
    Console.WriteLine($"Escreva o {i + 1}° Salário: ");
    salarios[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine($"O maior salaário digitados é: ");
maiorSalario = salarios[0];
for (int i = 0; i < salarios.Length; i++)
{
    if (salarios[i] > maiorSalario)
    {
        maiorSalario = salarios[i];
    }
}
Console.WriteLine(maiorSalario);