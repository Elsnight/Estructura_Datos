using AgendaClinica.Models;

namespace AgendaClinica.Utils;

public static class ReporteTurnos
{
    public static void MostrarTurnos(Turno[] turnos)
    {
        foreach (var turno in turnos)
        {
            Console.WriteLine($"Turno #{turno.Id} | {turno.Fecha} | {turno.Paciente.Nombre} {turno.Paciente.Apellido} | Motivo: {turno.Motivo}");
        }
    }
}
