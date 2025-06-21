using AgendaClinica.Models;

namespace AgendaClinica.Data;

// Clase estática que actúa como repositorio de datos en memoria para los turnos

public static class AgendaData
{
    //Array que almacena los turnos de la agenda con capacidad máxima de 100 turnos
    public static Turno[] Turnos = new Turno[100]; 
    
    //Contador que mantiene el registro de cuántos turnos hay actualmente en el sistema
    //También se utiliza para asignar posiciones en el array y generar IDs secuenciales
    public static int Contador = 0;
}
