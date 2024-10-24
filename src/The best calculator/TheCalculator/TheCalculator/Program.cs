//using System;

//class CalculadoraApp
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Aplicación calculadora");

//        while (true)
//        {
//            try
//            {
//                Console.WriteLine(@"
//                 1- Suma
//                 2- Resta
//                 3- Multiplicación
//                 4- División
//                 5- Salir
//                ");

//                Console.Write("Elige la operación a realizar: ");
//                int operacion = int.Parse(Console.ReadLine());

//                if (operacion >= 1 && operacion <= 4)
//                {
//                    Console.Write("Introduce el primer número: ");
//                    int operando1 = int.Parse(Console.ReadLine());

//                    Console.Write("Introduce el segundo número: ");
//                    int operando2 = int.Parse(Console.ReadLine());

//                    // Llamar a la función para realizar la operación
//                    RealizarOperacion(operacion, operando1, operando2);
//                }
//                else if (operacion == 5)
//                {
//                    Console.WriteLine("Chao");
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Opción errónea: " + operacion);
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("Ocurrió un error: " + e.Message);
//            }
//        }
//    }


//    static void RealizarOperacion(int operacion, int operando1, int operando2)
//    {
//        int resultado = 0;

//        switch (operacion)
//        {
//            case 1:
//                resultado = operando1 + operando2;
//                Console.WriteLine("La suma de los números es: " + resultado);
//                break;

//            case 2:
//                resultado = operando1 - operando2;
//                Console.WriteLine("La resta de los números es: " + resultado);
//                break;

//            case 3:
//                resultado = operando1 * operando2;
//                Console.WriteLine("La multiplicación de los números es: " + resultado);
//                break;

//            case 4:
//                if (operando2 != 0)
//                {
//                    resultado = operando1 / operando2;
//                    Console.WriteLine("La división de los números es: " + resultado);
//                }
//                else
//                {
//                    Console.WriteLine("Error: División por cero no permitida.");
//                }
//                break;
//        }
//        Console.WriteLine();
//    }
//}

using static System.Console;
List<decimal> typedNumbers = new List<decimal>();

decimal result = 0;
int typedOption = 1;
int wantToContinue = 0;

DisplayHeader();

try
{
    typedOption = Convert.ToInt32(ReadLine());

    // Ingreso de los primeros dos números
    typedNumbers.Add(GetNumber("Please Type the first number"));
    typedNumbers.Add(GetNumber("Please Type the second number"));

    while (wantToContinue != 2)
    {
        Console.WriteLine("Do you want to continue inserting numbers? 1. Yes, 2. No");
        wantToContinue = Convert.ToInt32(ReadLine());
        if (wantToContinue == 1)
        {
            typedNumbers.Add(GetNumber("Please Type another number"));
        }
    }

    // Llamar al método correspondiente basado en la opción
    switch (typedOption)
    {
        case 1:
            result = AddList(typedNumbers);
            break;
        case 2:
            result = SubtractList(typedNumbers);
            break;
        case 3:
            result = MultiplyList(typedNumbers);
            break;
        case 4:
            result = DivideList(typedNumbers);
            break;
        default:
            result = 0;
            Console.WriteLine("Invalid Option");
            break;
    }

    WriteLine($"The Result of the operation is: {result}");

}
catch (DivideByZeroException ex)
{
  WriteLine($"You cannot divide by zero: {ex.Message}");
}
catch (Exception ex)
{
  WriteLine($"An error occurred: {ex.Message}");
}
finally
{
  WriteLine("Closing DB Connection");
}

// Funciones

static decimal GetNumber(string message)
{
    WriteLine(message);
    return Convert.ToDecimal(ReadLine());
}

static decimal AddList(List<decimal> typedNumbers)
{
    decimal result = 0;
    foreach (decimal typedNumber in typedNumbers)
    {
        result += typedNumber;
    }
    return result;
}

static decimal SubtractList(List<decimal> typedNumbers)
{
    decimal result = typedNumbers[0];
    for (int i = 1; i < typedNumbers.Count; i++)
    {
        result -= typedNumbers[i];
    }
    return result;
}

static decimal MultiplyList(List<decimal> typedNumbers)
{
    decimal result = 1; // Inicializar en 1 para la multiplicación
    foreach (decimal typedNumber in typedNumbers)
    {
        result *= typedNumber;
    }
    return result;
}

static decimal DivideList(List<decimal> typedNumbers)
{
    decimal result = typedNumbers[0];
    for (int i = 1; i < typedNumbers.Count; i++)
    {
        if (typedNumbers[i] == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        result /= typedNumbers[i];
    }
    return result;
}

static void DisplayHeader()
{
    Console.WriteLine("This is the best calculator");
    Console.WriteLine("Please Type the option number you want");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("1. Sum\n2. Subtract\n3. Multiplication\n4. Division\n5. Exit");
}