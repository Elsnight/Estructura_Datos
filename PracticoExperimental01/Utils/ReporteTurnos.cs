using AgendaClinica.Models;

namespace AgendaClinica.Utils;

//Clase utilitaria para generar reportes de turnos en la consola
public static class ReporteTurnos
{
    // Muestra en la consola la lista de turnos con formato
    public static void MostrarTurnos(Turno[] turnos)
    {
        // Recorre cada turno del array y lo muestra con formato en la consola
        foreach (var turno in turnos)
        {
            // Imprime el turno con formato: ID | Fecha | Nombre Apellido | Motivo
            Console.WriteLine($"Turno #{turno.Id} | {turno.Fecha} | {turno.Paciente.Nombre} {turno.Paciente.Apellido} | Motivo: {turno.Motivo}");
        }
    }
}
