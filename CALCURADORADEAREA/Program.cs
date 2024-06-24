class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elije una figura geométrica:");
            Console.WriteLine("1. Rectángulo");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("3. Círculo");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
               
                case 1:
                    Console.Write("Ingresa la base del rectángulo: ");
                    double baseRectangulo = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa la altura del rectángulo: ");
                    double alturaRectangulo = double.Parse(Console.ReadLine());
                    double areaRectangulo = baseRectangulo * alturaRectangulo;
                    Console.WriteLine($"El área del rectángulo es: {areaRectangulo}");
                    break;

                case 2:
                    Console.Write("Ingresa la base del triángulo: ");
                    double baseTriangulo = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa la altura del triángulo: ");
                    double alturaTriangulo = double.Parse(Console.ReadLine());
                    double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
                    Console.WriteLine($"El área del triángulo es: {areaTriangulo}");
                    break;

                case 3:
                    Console.Write("Ingresa el radio del círculo: ");
                    double radio = double.Parse(Console.ReadLine());
                    double areaCirculo = Math.PI * Math.Pow(radio, 2);
                    Console.WriteLine($"El área del círculo es: {areaCirculo}");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
