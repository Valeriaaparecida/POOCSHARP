using Exercicio1;
using System.Globalization;

Triangulo x, y;
x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Digite o valor do lado A do triângulo X: ");
x.A = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.WriteLine("Digite o valor do lado B do triângulo X: "); 
x.B = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.WriteLine("Digite o valor do lado C do triângulo X: ");
x.C = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

Console.WriteLine("Digite o valor do lado A do triângulo Y: ");
y.A = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.WriteLine("Digite o valor do lado B do triângulo Y: ");
y.B = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.WriteLine("Digite o valor do lado C do triângulo Y: ");
y.C = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);


double areaX = x.Area();

double areaY = y.Area();

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