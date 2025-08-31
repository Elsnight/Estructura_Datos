using System;
using System.Collections.Generic;
using System.Linq;

namespace TraductorBasico
{
    public class Translator
    {
        private Dictionary<string, string> diccionario;

        public Translator()
        {
            diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "time", "tiempo" },
                { "person", "persona" },
                { "year", "año" },
                { "way", "camino" },
                { "day", "día" },
                { "thing", "cosa" },
                { "man", "hombre" },
                { "world", "mundo" },
                { "life", "vida" },
                { "hand", "mano" },
                { "part", "parte" },
                { "child", "niño" },
                { "eye", "ojo" },
                { "woman", "mujer" },
                { "place", "lugar" },
                { "work", "trabajo" },
                { "week", "semana" },
                { "case", "caso" },
                { "point", "punto" },
                { "government", "gobierno" },
                { "company", "empresa" }
            };
        }

        public string TraducirFrase(string frase)
        {
            string[] palabras = frase.Split(new char[] { ' ', ',', '.', ';', '!', '?' },
                                            StringSplitOptions.None);

            string traduccion = frase;

            foreach (string palabra in palabras)
            {
                if (diccionario.ContainsKey(palabra.ToLower()))
                {
                    string traduccionPalabra = diccionario[palabra.ToLower()];
                    traduccion = ReplaceWord(traduccion, palabra, traduccionPalabra);
                }
            }
            return traduccion;
        }

        private string ReplaceWord(string texto, string original, string traduccion)
        {
            return System.Text.RegularExpressions.Regex.Replace(
                texto,
                $@"\b{original}\b",
                traduccion,
                System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }

        public void AgregarPalabra(string ingles, string espanol)
        {
            if (!diccionario.ContainsKey(ingles))
            {
                diccionario.Add(ingles.ToLower(), espanol.ToLower());
                Console.WriteLine($"✔ Palabra agregada: {ingles} = {espanol}");
            }
            else
            {
                Console.WriteLine("⚠ Esa palabra ya existe en el diccionario.");
            }
        }
    }
}
