
using PessoaMaisVelha;
Pessoa pessoa1, pessoa2;
pessoa1 = new Pessoa();
pessoa2 = new Pessoa();


Console.Write("Digite o nome da primeira pessoa:");

pessoa1.Nome = Console.ReadLine();
Console.Write("Digite a idade da primeira pessoa:");
pessoa1.Idade = int.Parse(Console.ReadLine()!);

Console.Write("Digite o nome da segunda pessoa:");
pessoa2.Nome = Console.ReadLine();
Console.Write("Digite a idade da segunda pessoa:");
pessoa2.Idade = int.Parse(Console.ReadLine()!);  

if (pessoa1.Idade > pessoa2.Idade)
{
    Console.WriteLine($"A pessoa mais velha é {pessoa1.Nome} com {pessoa1.Idade} anos.");
}
else if (pessoa2.Idade > pessoa1.Idade)
{
    Console.WriteLine($"A pessoa mais velha é {pessoa2.Nome} com {pessoa2.Idade} anos.");
}
else
{
    Console.WriteLine("As duas pessoas têm a mesma idade.");
}