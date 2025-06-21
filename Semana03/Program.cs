using System;

class Program
{
    static void Main()
    {
        Estudiante estudiante = new Estudiante();

        Console.WriteLine("Ingrese el numero cedula del estudiante:");
        string? inputId = Console.ReadLine();
        if (!int.TryParse(inputId, out int id))
        {
            Console.WriteLine("cedula inválido. Debe ser un número.");
            return;
        }
        estudiante.Id = id;

        Console.WriteLine("Ingrese los nombres:");
        estudiante.Nombres = Console.ReadLine();

        Console.WriteLine("Ingrese los apellidos:");
        estudiante.Apellidos = Console.ReadLine();

        Console.WriteLine("Ingrese la dirección:");
        estudiante.Direccion = Console.ReadLine();

        for (int i = 0; i < estudiante.Telefonos.Length; i++)
        {
            Console.WriteLine($"Ingrese el teléfono {i + 1}:");
            estudiante.Telefonos[i] = Console.ReadLine() ?? "";
        }

        // 📍 Aquí es donde se integran los datos al final
        Console.Clear(); // Limpia la pantalla antes de mostrar
        Console.WriteLine("===== Datos del Estudiante =====");
        estudiante.MostrarDatos(); // 👈 Aquí se muestran los datos
    }
}
