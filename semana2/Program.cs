using System;

namespace FigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAMA DE FIGURAS GEOMÉTRICAS ===");
            Console.WriteLine();

            // Circulo
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            Circulo circulo = new Circulo(radio);
            circulo.MostrarInformacion();

            // Cuadrado
            Console.Write("Ingrese el lado del cuadrado: ");
            double lado = Convert.ToDouble(Console.ReadLine());
            Cuadrado cuadrado = new Cuadrado(lado);
            cuadrado.MostrarInformacion();

            Console.WriteLine("=== FIN DEL PROGRAMA ===");
        }
    }
}