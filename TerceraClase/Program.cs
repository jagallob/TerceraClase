using System;

class Program
{
    static void Main(string[] args)
    {

        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Calculadora Avanzada por consola(.Net 9 ");
            Console.WriteLine("========================================");

            Console.Write("Introduce el primer numero:");
            if (!double.TryParse(Console.ReadLine(), out double numero1))
            {
                Console.WriteLine("Entrada invalida, Presiona cualquier tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            Console.Write("Introduce el segundo numero: ");
            if (!double.TryParse(Console.ReadLine(), out double numero2))
            {
                Console.WriteLine("Entrada invalida, Presiona cualquier tecla para continuar...");
                Console.ReadKey();
                continue;

            }

            Console.WriteLine("\nSelecciona una operacion:");
            Console.WriteLine("1. Suma (+)");
            Console.WriteLine("2. Resta (-)");
            Console.WriteLine("3. Multiplicación (x)");
            Console.WriteLine("4. División (÷)");
            Console.WriteLine("5. Raiz cuadrada (√) del primer numero");
            Console.WriteLine("6. Elevar el primer numero al cuadrado (^2)");
            Console.WriteLine("7. Elevar el primer numero a la potencia del segundo numero (^n)");
            Console.WriteLine("8. Salir");
            Console.Write("Tu elección: ");

            string operacion = Console.ReadLine() ?? "";
            double resultado;
            Console.WriteLine(operacion);

            switch (operacion)
            {
                case "1": // Suma
                    resultado = numero1 + numero2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;

                case "2": // Resta
                    resultado = numero1 - numero2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;

                case "3": // Multiplicación
                    resultado = numero1 * numero2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;

                case "4": // División
                    if (numero2 == 0)
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }
                    else
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"Resultado: {resultado}");
                    }
                    break;

                case "5": // Raíz cuadrada
                    if (numero1 < 0)
                    {
                        Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un numero negativo.");

                    }
                    else
                    {
                        resultado = Math.Sqrt(numero1);
                        Console.WriteLine($"Resultado: {resultado}");

                    }
                    break;

                case "6": // Elevar al cuadrado
                    resultado = Math.Pow(numero1, 2);
                    Console.WriteLine($"Resultado: {resultado}");
                    break;


                case "7": // Elevar a una potencia
                    resultado = Math.Pow(numero1, numero2);
                    Console.WriteLine($"Resultado: {resultado}");
                    break;

                case "8": // Salir
                    continuar = false;
                    Console.WriteLine("Gracias por usar la calculadora, ¡Hasta luego!");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;

            }

            if (continuar)
            {
                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
