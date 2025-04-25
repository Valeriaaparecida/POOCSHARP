
using System.Globalization;


namespace Controle_de_estoque
{
    public class Produto
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;

        public double CalcularValorTotal()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

       
        public void RemoverProduto(int quantidade)
        {
            if (Quantidade >= quantidade)
            {
                Quantidade -= quantidade;
            }
            else
            {
                Console.WriteLine("Estoque insuficiente.");
            }
        }
         public override string ToString()
        {
            return $"{Nome}, R$ {Preco.ToString("F2",CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: R$ {CalcularValorTotal().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}