using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("===== MENÚ DE PROGRAMAS =====");
            Console.WriteLine("1. Mostrar asignaturas");
            Console.WriteLine("2. Media y desviación típica");
            Console.WriteLine("3. Producto escalar");
            Console.WriteLine("4. Contar vocales");
            Console.WriteLine("5. Verificar palíndromo");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            if (!int.TryParse(Console.ReadLine(), out opcion)) continue;

            Console.Clear();

            switch (opcion)
            {
                case 1:
                    MostrarAsignaturas();
                    break;
                case 2:
                    CalcularEstadisticas();
                    break;
                case 3:
                    ProductoEscalar();
                    break;
                case 4:
                    ContarVocales();
                    break;
                case 5:
                    VerificarPalindromo();
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 0);
    }

    static void MostrarAsignaturas()
    {
        var asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        Console.WriteLine("Asignaturas:");
        asignaturas.ForEach(a => Console.WriteLine($"- {a}"));
    }

    static void CalcularEstadisticas()
    {
        Console.Write("Ingrese números separados por coma: ");
        var input = Console.ReadLine();
        var numeros = input.Split(',').Select(n => double.Parse(n.Trim())).ToList();
        double media = numeros.Average();
        double sumaCuadrados = numeros.Sum(n => Math.Pow(n - media, 2));
        double desviacion = Math.Sqrt(sumaCuadrados / numeros.Count);

        Console.WriteLine($"Media: {media}");
        Console.WriteLine($"Desviación típica: {desviacion}");
    }

    static void ProductoEscalar()
    {
        var v1 = new List<int> { 1, 2, 3 };
        var v2 = new List<int> { -1, 0, 2 };
        int producto = v1.Zip(v2, (x, y) => x * y).Sum();
        Console.WriteLine("Vector A: (1, 2, 3)");
        Console.WriteLine("Vector B: (-1, 0, 2)");
        Console.WriteLine($"Producto escalar: {producto}");
    }

    static void ContarVocales()
    {
        Console.Write("Ingrese una palabra: ");
        var palabra = Console.ReadLine()?.ToLower();
        var vocales = "aeiou";
        foreach (var v in vocales)
        {
            int count = palabra.Count(c => c == v);
            Console.WriteLine($"Vocal '{v}': {count}");
        }
    }

    static void VerificarPalindromo()
    {
        Console.Write("Ingrese una palabra: ");
        var palabra = Console.ReadLine()?.ToLower();
        var inversa = new string(palabra.Reverse().ToArray());
        if (palabra == inversa)
            Console.WriteLine("Es un palíndromo.");
        else
            Console.WriteLine("No es un palíndromo.");
    }
}