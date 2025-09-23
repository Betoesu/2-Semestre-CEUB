using AppExercicio1Encapsulamento.Model;

Funcionario funcionario = new Funcionario();

Console.WriteLine("Informe o Nome do funcionário");
funcionario.Nome = Console.ReadLine();

Console.WriteLine("Informe a Data de Nascimento do funcionário");
funcionario.DataNascimento = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Informe o Salário do funcionário");
funcionario.Salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o Numero de Filhos do funcionário");
funcionario.NumeroFilhos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a Área de Atuação do funcionário");
funcionario.AreaAtuacao = Console.ReadLine();

string resultado = $"Nome: {funcionario.Nome}\r\n" +
    $"Data de Nascimento: {funcionario.DataNascimento}\r\n" +
    $"Salário: {funcionario.Salario}\r\n" +
    $"Número de Filhos: {funcionario.NumeroFilhos}\r\n" +
    $"Área de Atuação: {funcionario.AreaAtuacao}";
Console.WriteLine(resultado);