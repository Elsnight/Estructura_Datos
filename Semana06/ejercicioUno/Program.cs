using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        Console.WriteLine("=== Comparación de dos listas ===");

        // Cargar primera lista
        List<int> lista1 = CargarLista("primera lista");

        // Cargar segunda lista
        List<int> lista2 = CargarLista("segunda lista");

        // Comparar listas
        CompararListas(lista1, lista2);
    }

    static List<int> CargarLista(string nombre)
    {
        List<int> lista = new List<int>();
        Console.Write($"Ingrese la cantidad de elementos para la {nombre}: ");
        int cantidad = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"{nombre}[{i}]: ");
            int valor = int.Parse(Console.ReadLine());
            lista.Add(valor);
        }

        return lista;
    }

    static void CompararListas(List<int> lista1, List<int> lista2)
    {
        bool mismoTamanio = lista1.Count == lista2.Count;
        bool mismoContenido = true;

        if (mismoTamanio)
        {
            for (int i = 0; i < lista1.Count; i++)
            {
                if (lista1[i] != lista2[i])
                {
                    mismoContenido = false;
                    break;
                }
            }
        }
        else
        {
            mismoContenido = false;
        }

        // Mostrar resultados
        if (mismoTamanio && mismoContenido)
        {
            Console.WriteLine("\n✅ Las listas son iguales en tamaño y contenido.");
        }
        else if (mismoTamanio)
        {
            Console.WriteLine("\n⚠️ Las listas son iguales en tamaño, pero NO en contenido.");
        }
        else
        {
            Console.WriteLine("\n❌ Las listas NO tienen el mismo tamaño ni contenido.");
        }
    }
}
