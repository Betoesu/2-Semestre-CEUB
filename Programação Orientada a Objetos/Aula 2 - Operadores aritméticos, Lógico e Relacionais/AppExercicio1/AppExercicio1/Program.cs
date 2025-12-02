string nome, endereco, telefone, resultado;

Console.WriteLine("Informe o seu nome:");
nome = Console.ReadLine();

Console.WriteLine("Informe o seu endereço");
endereco = Console.ReadLine();

Console.WriteLine("Informe seu telefone:");
telefone = Console.ReadLine();

resultado = $"nome: {nome}\r\nEndereço: {endereco}\r\nTelefone:{telefone}";
Console.WriteLine(resultado);
