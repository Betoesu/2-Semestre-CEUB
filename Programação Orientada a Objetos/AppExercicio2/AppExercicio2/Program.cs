Int32 numero, sucessor, antecessor;

Console.WriteLine("Digite um numero para saber seu sucessor e o antecessor");
numero = Convert.ToInt32(Console.ReadLine());
sucessor = numero + 1;
antecessor = numero - 1;
Console.WriteLine($"Sucessor: {sucessor}\r\nAntecessor: {antecessor}");
Console.ReadKey();