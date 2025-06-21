using AgendaClinica.Models;
using AgendaClinica.Data;

namespace AgendaClinica.Services;

public class AgendaService
{
    public void AgendarTurno(Paciente paciente, DateTime fecha, string motivo)
    {
        if (AgendaData.Contador >= AgendaData.Turnos.Length)
        {
            Console.WriteLine("Agenda llena.");
            return;
        }

        var turno = new Turno
        {
            Id = AgendaData.Contador + 1,
            Paciente = paciente,
            Fecha = fecha,
            Motivo = motivo
        };

        AgendaData.Turnos[AgendaData.Contador] = turno;
        AgendaData.Contador++;
    }

    public Turno[] ConsultarTurnos()
    {
        return AgendaData.Turnos.Take(AgendaData.Contador).ToArray();
    }
    public void CancelarTurno(int id)
{
    int index = Array.FindIndex(AgendaData.Turnos, 0, AgendaData.Contador, t => t.Id == id);

    if (index >= 0)
    {
        // Reorganiza los turnos después de eliminar
        for (int i = index; i < AgendaData.Contador - 1; i++)
        {
            AgendaData.Turnos[i] = AgendaData.Turnos[i + 1];
        }
        AgendaData.Contador--;
        Console.WriteLine($"✅ Turno #{id} cancelado correctamente.");
    }
    else
    {
        Console.WriteLine("❌ Turno no encontrado.");
    }
}

}
