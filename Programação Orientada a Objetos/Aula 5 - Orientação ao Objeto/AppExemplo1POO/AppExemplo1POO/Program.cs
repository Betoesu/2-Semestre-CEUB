using AppExemplo1POO.Model;

//Criando vários objetos pessoa1
Pessoa pessoa1 = new Pessoa();
pessoa1.nome = "JOSÉ STENIO";
pessoa1.dataNascimento = Convert.ToDateTime("14/12/2006");
pessoa1.cpf = "123.123.123-12";
pessoa1.nomeMae = "MARIA JOSE";
pessoa1.nomePai = "JOÃO STENIO";
pessoa1.sexo = "Masculino";
Console.WriteLine(pessoa1.ImprimirPessoa());

Pessoa pessoa2 = new Pessoa();
pessoa2.nome = "Lara das Couves";
pessoa2.dataNascimento = Convert.ToDateTime("14/12/2006");
pessoa2.cpf = "123.123.123-12";
pessoa2.nomeMae = "Laris Jose";
pessoa2.nomePai = "João das Couves";
pessoa2.sexo = "Feminino";
Console.WriteLine(pessoa2.ImprimirPessoa());
