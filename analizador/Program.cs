using System;

class Progra
{
    static int ContarPalabras(string texto)
    {
        // Dividir el texto en palabras usando espacios como delimitador
        string[] palabras = texto.Split(' ');
        return palabras.Length;
    }

    static int ContarVocales(string texto)
    {
        // Contar las vocales (mayúsculas y minúsculas) en el texto
        int contador = 0;
        foreach (char c in texto)
        {
            if ("AEIOUaeiou".Contains(c))
                contador++;
        }
        return contador;
    }

    static string InvertirTexto(string texto)
    {
        // Invertir el orden de los caracteres en el texto
        char[] caracteres = texto.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }

    static void Main()
    {
        Console.Write("Ingresa un texto: ");
        string texto = Console.ReadLine();

        Console.WriteLine($"Número de palabras: {ContarPalabras(texto)}");
        Console.WriteLine($"Número de vocales: {ContarVocales(texto)}");
        Console.WriteLine($"Texto invertido: {InvertirTexto(texto)}");
    }
}
