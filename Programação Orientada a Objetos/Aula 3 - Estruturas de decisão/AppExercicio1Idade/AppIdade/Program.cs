//Int32 idade;
//string resultado;

//Console.WriteLine("Qual a sua idade: ");
//idade = Convert.ToInt32(Console.ReadLine());

//if (idade >= 18)
//{
//    resultado = $"a idade {idade} é maior ou igual a 18 anos";
//}
//else
//{
//    resultado = $"a idade {idade} é menor a 18 anos";
//}

Int32 idade;
string resultado;

Console.WriteLine("Qual a sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

resultado = (idade >= 18) ? "Você é maior de idade" : "Você é menor de idade";
Console.WriteLine(resultado);


