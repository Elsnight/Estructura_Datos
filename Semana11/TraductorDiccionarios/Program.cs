using System;

namespace TraductorBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Translator traductor = new Translator();
            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine("\n==================== MENÚ ====================");
                Console.WriteLine("1. Traducir una frase");
                Console.WriteLine("2. Agregar palabras al diccionario");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese la frase: ");
                            string frase = Console.ReadLine();
                            string resultado = traductor.TraducirFrase(frase);
                            Console.WriteLine($"Traducción: {resultado}");
                            break;

                        case 2:
                            Console.Write("Ingrese la palabra en inglés: ");
                            string ingles = Console.ReadLine();
                            Console.Write("Ingrese la traducción en español: ");
                            string espanol = Console.ReadLine();
                            traductor.AgregarPalabra(ingles, espanol);
                            break;

                        case 0:
                            Console.WriteLine("👋 Saliendo del programa...");
                            break;

                        default:
                            Console.WriteLine("❌ Opción inválida. Intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("❌ Ingrese un número válido.");
                }
            }
        }
    }
}
