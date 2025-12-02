double[] salarios = new double[5];

for (int i = 0; i < salarios.Length; i++)
{
    Console.WriteLine($"Informe o {i+1}° Salário");
    salarios[i] = Convert.ToDouble(Console.ReadLine());
    if (salarios[i] < 1000)
    {
        salarios[i] = salarios[i] *= 1.1;
    
    }
}

for (int i = 0;i < salarios.Length;i++)
{ 
    Console.WriteLine($"R${Math.Round(salarios[i],2)}");
}
