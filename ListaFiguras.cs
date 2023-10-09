namespace _P2_2_Figuras
{
    internal class ListaFiguras
    {
        public static void Main(string[] args)
        {
            List<Figura> listaFiguras = new List<Figura>
            {
                new Rectangulo(5.0, 3.0, Color.FromArgb(255, 0, 20, 40)),
                new Circulo(4.5, Color.FromArgb(255, 0, 20, 40)),
                new Circulo(2.5, Color.FromArgb(255, 0, 20, 40)),
                new TrianguloEquilatero(3.0, Color.FromArgb(255, 0, 20, 40))
            };

            foreach (Figura figura in listaFiguras)
            {
                Console.WriteLine(figura);
            }
        }
    }
}

