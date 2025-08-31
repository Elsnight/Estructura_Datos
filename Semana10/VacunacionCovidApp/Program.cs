using System;
using System.Collections.Generic;
using System.Linq;

namespace VacunacionCovid
{
    // Modelo de datos
    public class Ciudadano
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    // Gestor de vacunación
    public class CampaniaVacunacion
    {
        private HashSet<Ciudadano> _universo;
        private HashSet<Ciudadano> _pfizer;
        private HashSet<Ciudadano> _astrazeneca;

        public CampaniaVacunacion(int totalCiudadanos, int vacunadosPfizer, int vacunadosAstra)
        {
            _universo = GenerarCiudadanos(totalCiudadanos);
            _pfizer = GenerarVacunados(vacunadosPfizer, _universo);
            _astrazeneca = GenerarVacunados(vacunadosAstra, _universo);
        }

        // Genera todos los ciudadanos
        private HashSet<Ciudadano> GenerarCiudadanos(int total)
        {
            var lista = new HashSet<Ciudadano>();
            for (int i = 1; i <= total; i++)
            {
                lista.Add(new Ciudadano { Id = i, Nombre = $"Ciudadano {i}" });
            }
            return lista;
        }

        // Selecciona vacunados de forma aleatoria
        private HashSet<Ciudadano> GenerarVacunados(int cantidad, HashSet<Ciudadano> universo)
        {
            var rnd = new Random();
            return universo.OrderBy(_ => rnd.Next()).Take(cantidad).ToHashSet();
        }

        // ================= Operaciones =================

        public HashSet<Ciudadano> GetVacunados() => _pfizer.Union(_astrazeneca).ToHashSet();
        public HashSet<Ciudadano> GetNoVacunados() => _universo.Except(GetVacunados()).ToHashSet();
        public HashSet<Ciudadano> GetAmbasDosis() => _pfizer.Intersect(_astrazeneca).ToHashSet();
        public HashSet<Ciudadano> GetSoloPfizer() => _pfizer.Except(_astrazeneca).ToHashSet();
        public HashSet<Ciudadano> GetSoloAstrazeneca() => _astrazeneca.Except(_pfizer).ToHashSet();

        // ================= Reporte =================

        public void ImprimirReporte()
        {
            var vacunados = GetVacunados();
            var noVacunados = GetNoVacunados();
            var ambasDosis = GetAmbasDosis();
            var soloPfizer = GetSoloPfizer();
            var soloAstra = GetSoloAstrazeneca();

            Console.WriteLine("\n=== Reporte Campaña de Vacunación COVID-19 ===");
            Console.WriteLine($"Total ciudadanos: {_universo.Count}");
            Console.WriteLine($"Vacunados Pfizer: {_pfizer.Count}");
            Console.WriteLine($"Vacunados AstraZeneca: {_astrazeneca.Count}");
            Console.WriteLine($"Vacunados totales (A ∪ B): {vacunados.Count} ({Porcentaje(vacunados.Count)}%)");
            Console.WriteLine($"No vacunados: {noVacunados.Count} ({Porcentaje(noVacunados.Count)}%)");
            Console.WriteLine($"Ambas dosis (A ∩ B): {ambasDosis.Count} ({Porcentaje(ambasDosis.Count)}%)");
            Console.WriteLine($"Solo Pfizer (A - B): {soloPfizer.Count}");
            Console.WriteLine($"Solo AstraZeneca (B - A): {soloAstra.Count}");
        }

        private double Porcentaje(int cantidad) => Math.Round((cantidad * 100.0) / _universo.Count, 2);
    }

    // ================= MAIN =================
    class Program
    {
        static void Main()
        {
            Console.WriteLine("2525 - ESTRUCTURA DE DATOS - UEA / SEMANA 10 (Versión Mejorada)");

            var campania = new CampaniaVacunacion(500, 120, 150);
            campania.ImprimirReporte();
        }
    }
}
