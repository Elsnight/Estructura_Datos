# Sistema de Gestión de Agenda Clínica

Uso del agente de IA
Agente utilizado: Cloude
Porcentaje del código generado por el agente: ~30%
Descripción: Se utilizó el agente de IA para estructurar el proyecto, Y Documentacion.

## Descripción

Sistema de gestión de turnos para una clínica médica desarrollado en C#. Permite agendar, consultar y cancelar turnos médicos utilizando estructuras de datos básicas (arrays).

## Estructura del Proyecto

El proyecto está organizado en los siguientes componentes:

- **Models**: Contiene las definiciones de las estructuras de datos principales

  - `Paciente.cs`: Define el registro de paciente con cédula, nombre y apellido
  - `Turno.cs`: Define la estructura de un turno con ID, paciente, fecha y motivo

- **Data**: Maneja el almacenamiento de datos

  - `AgendaData.cs`: Contiene el array estático para almacenar los turnos y un contador

- **Services**: Implementa la lógica de negocio

  - `AgendaService.cs`: Contiene los métodos para agendar, consultar y cancelar turnos

- **Utils**: Herramientas de utilidad
  - `ReporteTurnos.cs`: Métodos para mostrar los turnos en consola

## Funcionalidades

1. **Agendar Turno**: Permite registrar un nuevo turno ingresando:

   - Datos del paciente (cédula, nombre, apellido)
   - Fecha y hora del turno
   - Motivo de la consulta

2. **Consultar Turnos**: Muestra la lista de todos los turnos agendados con su información completa.

3. **Cancelar Turno**: Elimina un turno existente utilizando su ID y reorganiza la estructura de datos. Se toma en cuenta el Valor 1,2 etc.

## Cómo Ejecutar

1. Asegúrate de tener instalado el SDK de .NET 9.0 o superior.
2. Abre una terminal en la carpeta del proyecto.
3. Ejecuta el siguiente comando:

```bash
dotnet run
```

## Implementación Técnica

- **Estructura de Datos**: Utiliza un array estático para almacenar hasta 100 turnos.
- **Contador**: Lleva registro de la cantidad de turnos agendados.
- **Eliminación**: Al cancelar un turno, reorganiza el array para evitar espacios vacíos.
- **Tipos de Datos**:
  - `record` para representar pacientes (inmutables)
  - `struct` para representar turnos

## Limitaciones

- Capacidad máxima de 100 turnos.
- No persiste datos entre ejecuciones (almacenamiento en memoria).
- No incluye validaciones complejas para fechas superpuestas.

## Posibles Mejoras Futuras

- Implementar persistencia de datos en archivos o base de datos.
- Agregar validación para evitar solapamiento de turnos.
- Implementar búsqueda de turnos por paciente o fecha.
- Desarrollar una interfaz gráfica.
