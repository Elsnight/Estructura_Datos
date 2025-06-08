using System;

namespace FigurasGeometricas
{
    public class Cuadrado : IFiguraGeometrica
    {
        private double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public double CalcularArea()
        {
            return lado * lado;
        }

        public double CalcularPerimetro()
        {
            return 4 * lado;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("=== INFORMACIÓN DEL CUADRADO ===");
            Console.WriteLine($"Lado: {lado:F2}");
            Console.WriteLine($"Área: {CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {CalcularPerimetro():F2}");
            Console.WriteLine();
        }
    }
}
