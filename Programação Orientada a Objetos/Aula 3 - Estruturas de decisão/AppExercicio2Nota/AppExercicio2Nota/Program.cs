double nota;
string resultado;

Console.WriteLine("Nota do Aluno: ");
nota = Convert.ToDouble(Console.ReadLine());

//if (nota >= 7) 
//{
//    resultado = "Aprovado";
//}

//else if ((nota >= 5) && (nota < 7))
//{
//    resultado = "Recuperação";
//}

//else
//{
//    resultado = "Reprovado";
//}

resultado = (nota>=7) ? "Aprovado" : ((nota >= 5) && (nota < 7)) ? "Recuperação" : "Reprovado";
Console.WriteLine(resultado);