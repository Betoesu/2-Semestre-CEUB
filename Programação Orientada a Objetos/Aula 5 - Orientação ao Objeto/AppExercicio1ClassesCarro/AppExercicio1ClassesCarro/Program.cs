using AppExercicio1ClasseAlugaFacil.Model;

//Criando 1° Objeto
Cliente cliente = new Cliente();
Console.WriteLine("Informe o nome do cliente: ");
cliente.nome = Console.ReadLine();

Console.WriteLine("Informe o Cpf do cliente: ");
cliente.cpf = Console.ReadLine();

Console.WriteLine("Informe o numero da cnh do cliente: ");
cliente.cnh = Console.ReadLine();

Console.WriteLine(cliente.ImprimirCliente());

//Criando 2° Objeto
Cliente cliente2 = new Cliente();
Console.WriteLine("Informe o nome do cliente: ");
cliente2.nome = Console.ReadLine();

Console.WriteLine("Informe o Cpf do cliente: ");
cliente2.cpf = Console.ReadLine();

Console.WriteLine("Informe o numero da cnh do cliente: ");
cliente2.cnh = Console.ReadLine();

Console.WriteLine(cliente2.ImprimirCliente());



//Criando 1° Carro
Carro carro = new Carro();
Console.WriteLine("Informe a placa do carro");
carro.placa = Console.ReadLine();

Console.WriteLine("Informe o fabricante do carro");
carro.fabricante = Console.ReadLine();

Console.WriteLine("Informe a modelo do carro");
carro.modelo = Console.ReadLine();

Console.WriteLine("Informe o ano do carro");
carro.ano = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a cor do carro");
carro.cor = Console.ReadLine();

Console.WriteLine("Informeo valor da diária do carro");
carro.valorDiaria = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(carro.ImprimirCarro());


//Criando 2° Carro
Carro carro2 = new Carro();
Console.WriteLine("Informe a placa do carro");
carro2.placa = Console.ReadLine();

Console.WriteLine("Informe o fabricante do carro");
carro2.fabricante = Console.ReadLine();

Console.WriteLine("Informe a modelo do carro");
carro2.modelo = Console.ReadLine();

Console.WriteLine("Informe o ano do carro");
carro2.ano = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a cor do carro");
carro2.cor = Console.ReadLine();

Console.WriteLine("Informeo valor da diária do carro");
carro2.valorDiaria = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(carro2.ImprimirCarro());




