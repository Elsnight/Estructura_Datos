namespace AgendaClinica.Models;

public struct Turno
{
    public int Id;
    public Paciente Paciente;
    public DateTime Fecha;
    public string Motivo;
}
