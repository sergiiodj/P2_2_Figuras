//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace _P2_2_Figuras;

public class P2_2_Figuras
{
  static void Main(string[] args)
  {
    Rectangulo r1 = new Rectangulo(3.2, 2.8);
    Console.WriteLine(r1);

    TrianguloEquilatero t1 = new TrianguloEquilatero(6.5, 3.5);
    Console.WriteLine(t1);

    Circulo c1 = new Circulo(24.2);
    Console.WriteLine(c1);

  }

}