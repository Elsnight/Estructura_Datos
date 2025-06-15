using System;

public class Estudiante
{
    public int Id { get; set; }
    public string? Nombres { get; set; }
    public string? Apellidos { get; set; }
    public string? Direccion { get; set; }
    public string[] Telefonos { get; set; }

    public Estudiante()
    {
        // Inicializa el array de teléfonos con 3 elementos
        Telefonos = new string[3];
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Cedula: {Id}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos:");
        
        // Mostrar cada teléfono con su índice
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($"\tIndex [{i}] = {Telefonos[i]}");
        }
        
        // Mostrar el array completo
        Console.Write("Array completo: [");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.Write(Telefonos[i]);
            if (i < Telefonos.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}