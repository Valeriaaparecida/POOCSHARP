
using CalcularRetangulo;
using System.Globalization;

Retangulo retangulo = new Retangulo();
Console.WriteLine("Digite a largura do retângulo: ");
retangulo.Largura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.WriteLine("Digite a altura do retângulo: ");    
retangulo.Altura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.WriteLine($"Área: {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Perímetro: {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");   
Console.WriteLine($"Diagonal: {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");