using Exercicio1;
using System.Globalization;

Triangulo x, y;
x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Digite o valor do lado A do triângulo X: ");
x.A = int.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.WriteLine("Digite o valor do lado B do triângulo X: "); 
x.B = int.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.WriteLine("Digite o valor do lado C do triângulo X: ");
x.C = int.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

Console.WriteLine("Digite o valor do lado A do triângulo Y: ");
y.A = int.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.WriteLine("Digite o valor do lado B do triângulo Y: ");
y.B = int.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.WriteLine("Digite o valor do lado C do triângulo Y: ");
y.C = int.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

double p = (x.A + x.B + x.C) / 2.0;
double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
double p2 = (y.A + y.B + y.C) / 2.0;
double areaY = Math.Sqrt(p2 * (p2 - y.A) * (p2 - y.B) * (p2 - y.C));

Console.WriteLine($"Área do triângulo X: {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Área do triângulo Y: {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

if (areaX > areaY)
{
    Console.WriteLine("Triângulo X é maior que o triângulo Y.");
}
else if (areaY > areaX)
{
    Console.WriteLine("Triângulo Y é maior que o triângulo X.");
}
else
{
    Console.WriteLine("Os triângulos têm a mesma área.");
}
Console.WriteLine("Pressione qualquer tecla para sair...");