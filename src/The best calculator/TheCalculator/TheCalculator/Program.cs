using System;

class CalculadoraApp
{
    static void Main(string[] args)
    {
        Console.WriteLine("Aplicación calculadora");

        while (true)
        {
            try
            {
                Console.WriteLine(@"
                 1- Suma
                 2- Resta
                 3- Multiplicación
                 4- División
                 5- Salir
                ");

                Console.Write("Elige la operación a realizar: ");
                int operacion = int.Parse(Console.ReadLine());

                if (operacion >= 1 && operacion <= 4)
                {
                    Console.Write("Introduce el primer número: ");
                    int operando1 = int.Parse(Console.ReadLine());

                    Console.Write("Introduce el segundo número: ");
                    int operando2 = int.Parse(Console.ReadLine());

                    // Llamar a la función para realizar la operación
                    RealizarOperacion(operacion, operando1, operando2);
                }
                else if (operacion == 5)
                {
                    Console.WriteLine("Chao");
                    break;
                }
                else
                {
                    Console.WriteLine("Opción errónea: " + operacion);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrió un error: " + e.Message);
            }
        }
    }


    static void RealizarOperacion(int operacion, int operando1, int operando2)
    {
        int resultado = 0;

        switch (operacion)
        {
            case 1:
                resultado = operando1 + operando2;
                Console.WriteLine("La suma de los números es: " + resultado);
                break;

            case 2:
                resultado = operando1 - operando2;
                Console.WriteLine("La resta de los números es: " + resultado);
                break;

            case 3:
                resultado = operando1 * operando2;
                Console.WriteLine("La multiplicación de los números es: " + resultado);
                break;

            case 4:
                if (operando2 != 0)
                {
                    resultado = operando1 / operando2;
                    Console.WriteLine("La división de los números es: " + resultado);
                }
                else
                {
                    Console.WriteLine("Error: División por cero no permitida.");
                }
                break;
        }
        Console.WriteLine();
    }
}
