using AgendaClinica.Models;
using AgendaClinica.Data;

namespace AgendaClinica.Services;

//Servicio que implementa la lógica de negocio para la gestión de turnos médicos
public class AgendaService
{
    //Registra un nuevo turno en la agenda
    public void AgendarTurno(Paciente paciente, DateTime fecha, string motivo)
    {
        // Verifica si hay espacio disponible en la agenda
        if (AgendaData.Contador >= AgendaData.Turnos.Length)
        {
            Console.WriteLine("Agenda llena.");
            return;
        }

        // Crea un nuevo objeto Turno con los datos proporcionados
        var turno = new Turno
        {
            Id = AgendaData.Contador + 1, // Asigna un ID secuencial
            Paciente = paciente,
            Fecha = fecha,
            Motivo = motivo
        };

        // Almacena el turno en el array y actualiza el contador
        AgendaData.Turnos[AgendaData.Contador] = turno;
        AgendaData.Contador++;
    }

    //Obtiene la lista de todos los turnos agendados
   
    public Turno[] ConsultarTurnos()
    {
        // Devuelve una copia del array con solo los elementos ocupados (hasta el contador)
        return AgendaData.Turnos.Take(AgendaData.Contador).ToArray();
    }

    // Cancela un turno existente por su ID
 
    public void CancelarTurno(int id)
    {
        // Busca la posición del turno en el array usando su ID
        int index = Array.FindIndex(AgendaData.Turnos, 0, AgendaData.Contador, t => t.Id == id);

        if (index >= 0)
        {
            // Reorganiza los turnos después de eliminar (desplazando los elementos)
            for (int i = index; i < AgendaData.Contador - 1; i++)
            {
                AgendaData.Turnos[i] = AgendaData.Turnos[i + 1];
            }
            AgendaData.Contador--; // Reduce el contador ya que eliminamos un turno
            Console.WriteLine($"✅ Turno #{id} cancelado correctamente.");
        }
        else
        {
            Console.WriteLine("❌ Turno no encontrado.");
        }
    }
}
