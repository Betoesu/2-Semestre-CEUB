using ExemploClasseAbstrataBCC.Model;

//Personagem personagem = new Personagem();

Mago mago = new Mago();
Guerreiro guerreiro = new Guerreiro();

Console.WriteLine("Informe o nome do Mago: ");
mago.Nome = Console.ReadLine();
mago.Nivel = 10;
mago.Vida = 5;

Console.WriteLine($"O mago {mago.Nome} está nível {mago.Nivel} e tem {mago.Vida} de vida");