using Controle_de_estoque;
using System.Globalization;

Produto p = new Produto();

Console.Write("Entre com o nome do produto:");
p.Nome = Console.ReadLine();
Console.Write("Entre com o preço do produto:");
p.Preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);    
Console.Write("Entre com a quantidade do produto:");
p.Quantidade = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine($"Dados do produto: {p}");
Console.WriteLine();
Console.Write("Digite o número de produtos a serem adicionados ao estoque:");
int quantidade = int.Parse(Console.ReadLine()!);
p.AdicionarProduto(quantidade);
Console.WriteLine();
Console.WriteLine($"Dados atualizados: {p}");
Console.WriteLine();
Console.Write("Digite o número de produtos a serem removidos ao estoque:");
quantidade = int.Parse(Console.ReadLine()!);
p.RemoverProduto(quantidade);
Console.WriteLine();
Console.WriteLine($"Dados atualizados: {p}");