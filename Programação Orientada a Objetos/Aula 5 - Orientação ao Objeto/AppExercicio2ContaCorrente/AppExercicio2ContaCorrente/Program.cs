using AppExercicio2ContaCorrente.model;

ContaCorrente contaCorrente = new ContaCorrente();

Console.WriteLine("Digite o número da conta");
contaCorrente.numeroConta = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o nome do banco");
contaCorrente.nomeBanco = Console.ReadLine();

Console.WriteLine("Digite o nome do cliente");
contaCorrente.nomeCliente = Console.ReadLine();

Console.WriteLine("Digite o nome da agência");
contaCorrente.nomeAgencia = Console.ReadLine();

Console.WriteLine(contaCorrente.Imprimir());
