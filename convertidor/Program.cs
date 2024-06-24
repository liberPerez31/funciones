using System;

class Program
{
    static double CelsiusAFahrenheit(double celsius)
    {
        // Fórmula: Fahrenheit = (Celsius * 9/5) + 32
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitACelsius(double fahrenheit)
    {
        // Fórmula: Celsius = (Fahrenheit - 32) * 5/9
        return (fahrenheit - 32) * 5 / 9;
    }

    static double CelsiusAKelvin(double celsius)
    {
        // Fórmula: Kelvin = Celsius + 273.15
        return celsius + 273.15;
    }

    static void Main()
    {
        Console.WriteLine("¿Qué conversión deseas realizar?");
        Console.WriteLine("1. Celsius a Fahrenheit");
        Console.WriteLine("2. Fahrenheit a Celsius");
        Console.WriteLine("3. Celsius a Kelvin");
        Console.Write("Ingresa el número de opción: ");
        int opcion = int.Parse(Console.ReadLine());

        Console.Write("Ingresa la temperatura: ");
        double temperatura = double.Parse(Console.ReadLine());

        double resultado = 0;

        switch (opcion)
        {
            case 1:
                resultado = CelsiusAFahrenheit(temperatura);
                Console.WriteLine($"Resultado: {resultado} °F");
                break;
            case 2:
                resultado = FahrenheitACelsius(temperatura);
                Console.WriteLine($"Resultado: {resultado} °C");
                break;
            case 3:
                resultado = CelsiusAKelvin(temperatura);
                Console.WriteLine($"Resultado: {resultado} K");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
