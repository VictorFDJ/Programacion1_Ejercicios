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