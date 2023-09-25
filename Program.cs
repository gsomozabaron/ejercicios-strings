using ejercicio_1;
using System.Text;

namespace tutorias
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///Console.WriteLine("ingrese palabra");
            ///String palabra = Console.ReadLine();
            ///Console.WriteLine( palabra );
            string palabra = "peluca";
            string texto = "ejercicio de strings";
            string parrafo = "test de string a parrafo. si todo sale bien. se vera en tres renglones";
            string palabra2 = "text sb";

            Metodos.ContarLetras(palabra);
            Metodos.ContarPalabras(texto);
            Metodos.ContarVocales(palabra);
            Metodos.ContarConsonantes(palabra);
            Metodos.ReemplazarCaracter(palabra, 'p', 'c');
            Metodos.ConvertirStringAEntero("224");
            Metodos.ConvertirStringAEntero("A224");
            Metodos.ConvertirStringASB(palabra);
            Metodos.ConvertirParrafoASB(parrafo);
            Metodos.MostrarTexto(texto, palabra);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("mostrar sb");
            sb.AppendLine(palabra);
            sb.AppendLine(palabra2);
            sb.AppendLine(texto);
            sb.ToString();
            Metodos.MostrarTextoSB(sb);

           

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
