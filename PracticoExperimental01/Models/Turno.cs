namespace AgendaClinica.Models;

//Estructura que representa un turno médico en el sistema
//Se implementa como struct porque es un tipo de valor simple con propiedades directas
public struct Turno
{
    //Identificador único del turno
    public int Id;
    
    //Información del paciente asociado al turno
    public Paciente Paciente;
    
    //Fecha y hora programada para el turno
    public DateTime Fecha;
    
    //Motivo o descripción de la consulta médica
    public string Motivo;
}
