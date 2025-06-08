using System;

namespace FigurasGeometricas
{
    public class Circulo : IFiguraGeometrica
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("=== INFORMACIÓN DEL CÍRCULO ===");
            Console.WriteLine($"Radio: {radio:F2}");
            Console.WriteLine($"Área: {CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {CalcularPerimetro():F2}");
            Console.WriteLine();
        }
    }
}
