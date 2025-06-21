using AgendaClinica.Models;
using AgendaClinica.Services;
using AgendaClinica.Utils;

var agenda = new AgendaService();
bool salir = false;

while (!salir)
{
    Console.WriteLine("\n👋 Bienvenido a la Agenda de Turnos de la Clínica");
    Console.WriteLine("¿Qué deseas hacer?");
    Console.WriteLine("1. Agendar un turno");
    Console.WriteLine("2. Consultar turnos");
    Console.WriteLine("3. Cancelar un turno");
    Console.WriteLine("4. Salir");

    Console.Write("Selecciona una opción (1-4): ");
    string opcion = Console.ReadLine()!;

    switch (opcion)
    {
        case "1":
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

            var paciente = new Paciente(cedula, nombre, apellido);
            agenda.AgendarTurno(paciente, fecha, motivo);
            break;

        case "2":
            Console.WriteLine("\n📋 Lista de turnos:");
            var turnos = agenda.ConsultarTurnos();
            ReporteTurnos.MostrarTurnos(turnos);
            break;

        case "3":
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
            salir = true;
            Console.WriteLine("👋 ¡Gracias por usar la agenda de turnos!");
            break;

        default:
            Console.WriteLine("❌ Opción no válida. Intente de nuevo.");
            break;
    }
}
