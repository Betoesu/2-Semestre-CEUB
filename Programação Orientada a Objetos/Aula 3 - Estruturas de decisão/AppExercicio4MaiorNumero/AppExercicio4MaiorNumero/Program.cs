Int32 numero1, numero2;
string resultado;

Console.WriteLine("Digite um número: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite outro número: ");
numero2 = Convert.ToInt32(Console.ReadLine());

resultado = (numero1 >  numero2) ? $"O {numero1} é o maior número" : $"O {numero2} é o maior número";
Console.WriteLine(resultado);