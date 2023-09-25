using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Metodos
    {
        public static void ContarLetras(string palabra)
        {
            int cantidadLetras = 0;
            if (palabra.Length != 0)
            {
                cantidadLetras = palabra.Length;
            }
            Console.WriteLine($"cantidad de letras en {palabra}: {cantidadLetras} letras"); 
        }

        
        public static void ContarLetras2(string palabra)
        {
            Console.WriteLine($"cantidad de letras en {palabra}: {palabra.Length} letras");
        }

        public static void ContarPalabras(string texto)
        {
            string[] palabras = texto.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"cantidad de palabas en {texto}: {palabras.Length}");
        }

        public static void ContarVocales(string palabra)
        {
            int count = 0;
            foreach (char c in palabra)
            {
                if ("aeiouAEIOU".Contains(c))
                {
                    count++;
                }
            }
            Console.WriteLine($"natidad de vocales en {palabra}: {count}");
        }

        public static void ContarConsonantes(string palabra)
        {
            int count = 0;
            foreach (char c in palabra)
            {
                if (Char.IsLetter(c) && !"aeiouAEIOU".Contains(c))
                {
                    count++;
                }
            }
            Console.WriteLine($"natidad de consonantes en {palabra}: {count}");
        }

        public static void ReemplazarCaracter(string palabra, char original, char nuevo)
        {
            Console.WriteLine($"reemplazar {original} por {nuevo} en {palabra} : {palabra.Replace(original, nuevo)}");
        }

        public static void ConvertirStringAEntero(string texto)
        {
            int numeroEntero;
            bool sePudoConvertir = int.TryParse(texto, out numeroEntero);
            Console.WriteLine($"se pudo convertir '{texto}' a entero?: {sePudoConvertir} {numeroEntero}");
        }

        public static void ConvertirStringASB(string palabra)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(palabra);
            Console.WriteLine(sb.ToString());
        }

        public static void ConvertirParrafoASB(string parrafo)
        {
            string[] frases = parrafo.Split('.');
            StringBuilder sb = new StringBuilder();
            foreach (string frase in frases)
            {
                sb.AppendLine(frase.Trim() + ".");
            }
            Console.WriteLine(sb.ToString());
        }

        public static void MostrarTexto(string mensaje, string texto)
        {
            Console.WriteLine(mensaje + ": " + texto);
        }

        public static void MostrarTextoSB(StringBuilder texto)
        {
            Console.WriteLine(texto.ToString());
        }
        

    }
}

/*
* 
Crear la clase TextOperations y sus métodos estáticos para trabajar con cadenas.

Métodos:

● int ContarLetras(string palabra): Cuenta la cantidad de letras que tiene una palabra.

● int ContarPalabras(string texto): Cuenta la cantidad de palabras que contiene el texto;

● int ContarVocales(string palabra): Cuenta la cantidad de vocales que contiene una palabra.

● int ContarConsonantes(string palabra): Cuenta la cantidad de consonantes que contiene una palabra.

● string ReemplazarCaracter(string palabra, char original, char nuevo): Reemplaza el carácter original por el indicado.

● bool ConvertirStringAEntero(string texto, int xxx numeroEntero): Devuelve si es posible convertir un texto 
a entero y si es posible lo devuelve en la variable numeroEntero.

● StringBuilder ConvertirStringASB(string palabra): Recibe un string y lo guarda en un StringBuilder.

● StringBuilder ConvertirParrafoASB(string parrafo): Recibe un párrafo y guarda cada frase en una línea nueva de un 
StringBuilder. Cada frase finaliza cuando encontramos un punto (.).

● void MostrarTexto(string mensaje, string texto): Muestra por consola el mensaje y el texto recibido.

● void MostrarTextoSB(StringBuilder texto): Muestra por consola el texto recibido.
*/
