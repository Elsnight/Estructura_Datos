using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    static void Main()
    {
        Console.Write("Ingrese el número de discos: ");
        int n = int.Parse(Console.ReadLine());

        Stack<int> origen = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();
        Stack<int> destino = new Stack<int>();

        // Llenar la torre de origen con discos
        for (int i = n; i >= 1; i--)
        {
            origen.Push(i);
        }

        MostrarTorres(origen, auxiliar, destino, "Estado inicial");

        ResolverHanoi(n, origen, destino, auxiliar, "A", "C", "B");

        MostrarTorres(origen, auxiliar, destino, "Estado final");
    }

    static void ResolverHanoi(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
            MostrarTorres(origen, auxiliar, destino);
            return;
        }

        ResolverHanoi(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);
        ResolverHanoi(1, origen, destino, auxiliar, nombreOrigen, nombreDestino, nombreAuxiliar);
        ResolverHanoi(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
    }

    static void MostrarTorres(Stack<int> a, Stack<int> b, Stack<int> c, string mensaje = "")
    {
        if (!string.IsNullOrEmpty(mensaje))
            Console.WriteLine($"\n--- {mensaje} ---");

        MostrarTorre("A", a);
        MostrarTorre("B", b);
        MostrarTorre("C", c);
        Console.WriteLine(new string('-', 30));
    }

    static void MostrarTorre(string nombre, Stack<int> torre)
    {
        Console.Write($"{nombre}: ");
        foreach (var disco in torre.ToArray())
        {
            Console.Write(disco + " ");
        }
        Console.WriteLine();
    }
}
