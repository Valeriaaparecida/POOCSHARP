
using System.Globalization;
using ComparaSalario;

Funcionario f1, f2;
f1 = new Funcionario();
f2 = new Funcionario();

Console.WriteLine("Digite o nome do funcionário 1:");
f1.Nome = Console.ReadLine();
Console.WriteLine("Digite o salário do funcionário 1:");
f1.Salario = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

Console.WriteLine("Digite o nome do funcionário 2:");
f2.Nome = Console.ReadLine();
Console.WriteLine("Digite o salário do funcionário 2:");
f2.Salario = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

if(f1.Salario > f2.Salario)
{
    Console.WriteLine($"O funcionário {f1.Nome} tem o maior salário: {f1.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
}
else if (f1.Salario < f2.Salario)
{
    Console.WriteLine($"O funcionário {f2.Nome} tem o maior salário: {f2.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
}
else
{
    Console.WriteLine("Os funcionários têm salários iguais.");
}