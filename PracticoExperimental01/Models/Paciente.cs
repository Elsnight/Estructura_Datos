namespace AgendaClinica.Models;

/// Record que representa la información de un paciente
/// Se utiliza un record porque:
/// 1. Ofrece inmutabilidad (los datos del paciente no cambian)
/// 2. Proporciona igualdad basada en valores (dos pacientes con mismos datos son iguales)
/// 3. Simplifica la sintaxis con parámetros posicionales

public record Paciente(string Cedula, string Nombre, string Apellido);
