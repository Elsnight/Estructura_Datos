using AgendaClinica.Models;
using AgendaClinica.Services;
using AgendaClinica.Utils;

// Inicialización del servicio de agenda que contiene la lógica de negocio
var agenda = new AgendaService();
bool salir = false;

// Bucle principal del programa que se ejecuta hasta que el usuario decide salir
while (!salir)
{
    // Menú principal del sistema
    Console.WriteLine("\n👋 Bienvenido a la Agenda de Turnos de la Clínica");
    Console.WriteLine("¿Qué deseas hacer?");
    Console.WriteLine("1. Agendar un turno");
    Console.WriteLine("2. Consultar turnos");
    Console.WriteLine("3. Cancelar un turno");
    Console.WriteLine("4. Salir");

    Console.Write("Selecciona una opción (1-4): ");
    string opcion = Console.ReadLine()!;

    // Procesamiento de la opción seleccionada por el usuario
    switch (opcion)
    {
        case "1":
            // Captura de datos para agendar un nuevo turno
            Console.Write("Ingrese cédula del paciente: ");
            string cedula = Console.ReadLine()!;
            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine()!;
            Console.Write("Ingrese apellido: ");
            string apellido = Console.ReadLine()!;
            Console.Write("Ingrese la fecha del turno (yyyy-mm-dd hh:mm): ");
            DateTime fecha = DateTime.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el motivo de la consulta: ");
            string motivo = Console.ReadLine()!;

            // Creación del objeto paciente y registro del turno
            var paciente = new Paciente(cedula, nombre, apellido);
            agenda.AgendarTurno(paciente, fecha, motivo);
            break;

        case "2":
            // Consulta y visualización de todos los turnos agendados
            Console.WriteLine("\n📋 Lista de turnos:");
            var turnos = agenda.ConsultarTurnos();
            ReporteTurnos.MostrarTurnos(turnos);
            break;

        case "3":
            // Cancelación de un turno mediante su ID
            Console.Write("Ingrese el ID del turno a cancelar: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                agenda.CancelarTurno(id);
            }
            else
            {
                Console.WriteLine("❌ ID inválido");
            }
            break;

        case "4":
            // Salida del programa
            salir = true;
            Console.WriteLine("👋 ¡Gracias por usar la agenda de turnos!");
            break;

        default:
            // Manejo de opciones no válidas
            Console.WriteLine("❌ Opción no válida. Intente de nuevo.");
            break;
    }
}
