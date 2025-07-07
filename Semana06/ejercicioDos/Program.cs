using System;

class Nodo
{
    public int Valor;
    public Nodo? Siguiente;

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}

class ListaEnlazada
{
    private Nodo? cabeza = null;

    public void AgregarAlFinal(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    public void Eliminar(int valor)
    {
        if (cabeza == null) return;

        if (cabeza.Valor == valor)
        {
            cabeza = cabeza.Siguiente;
            return;
        }

        Nodo actual = cabeza;
        while (actual.Siguiente != null && actual.Siguiente.Valor != valor)
        {
            actual = actual.Siguiente;
        }

        if (actual.Siguiente != null)
        {
            actual.Siguiente = actual.Siguiente.Siguiente;
        }
    }

    public void Mostrar()
    {
        Nodo? actual = cabeza;
        Console.WriteLine("Elementos de la lista:");
        while (actual != null)
        {
            Console.Write(actual.Valor + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();
        int opcion = -1;

        do
        {
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Agregar elemento");
            Console.WriteLine("2. Eliminar elemento");
            Console.WriteLine("3. Mostrar lista");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            string? entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("Entrada no válida.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el número a agregar: ");
                    if (int.TryParse(Console.ReadLine(), out int valorAgregar))
                        lista.AgregarAlFinal(valorAgregar);
                    else
                        Console.WriteLine("Número inválido.");
                    break;

                case 2:
                    Console.Write("Ingrese el número a eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int valorEliminar))
                        lista.Eliminar(valorEliminar);
                    else
                        Console.WriteLine("Número inválido.");
                    break;

                case 3:
                    lista.Mostrar();
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 0);
    }
}
