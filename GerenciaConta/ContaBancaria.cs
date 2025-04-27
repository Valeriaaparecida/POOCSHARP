
using System.Globalization;


namespace GerenciaConta
{
    public class ContaBancaria
    {
        public int Numero { get; private set; }
         public string? Titular { get; set; }
          public double Saldo { get; private set; }

          public ContaBancaria(int numero, string? titular)
        {
            Numero = numero;
            Titular = titular;
        
        }

          public ContaBancaria(int numero, string? titular, double depositoInicial):this(numero, titular)
        {
       
            Depositar(depositoInicial);
        }



        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }
        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Saldo -= 5.00; // Taxa de saque
            }
            else
            {
                Console.WriteLine("Valor de saque inválido ou saldo insuficiente.");
            }
        }
          public override string ToString()
        {
            return $"Conta: {Numero}, Titular: {Titular}, Saldo: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}