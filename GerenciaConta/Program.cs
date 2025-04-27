

using System.Globalization;
using GerenciaConta;

ContaBancaria conta;

Console.WriteLine("Digite o número da conta:");
int Numero = int.Parse(Console.ReadLine()!);
Console.WriteLine("Digite o nome do titular da conta:");
string titular = Console.ReadLine();
Console.WriteLine("Haverá depósito inicial? (s/n)");
char resposta = char.Parse(Console.ReadLine()!);
if (resposta == 's' || resposta == 'S')
{
    Console.WriteLine("Digite o valor do depósito inicial:");
    double depositoInicial = double.Parse(Console.ReadLine()!,CultureInfo.InvariantCulture);
    conta = new ContaBancaria(Numero, titular, depositoInicial);
}
else
{
    conta = new ContaBancaria(Numero, titular);
}
Console.WriteLine();
Console.WriteLine("Dados da conta:");
Console.WriteLine(conta);
Console.WriteLine();

Console.Write("Digite um valor para depósito:");
double valorDeposito = double.Parse(Console.ReadLine()!,CultureInfo.InvariantCulture);
conta.Depositar(valorDeposito);
Console.WriteLine("Dados atualizados:");
Console.WriteLine(conta);
Console.WriteLine();

Console.Write("Digite um valor para saque:");
double valorSaque = double.Parse(Console.ReadLine()!,CultureInfo.InvariantCulture);
conta.Sacar(valorSaque);
Console.WriteLine("Dados atualizados:");
Console.WriteLine(conta);