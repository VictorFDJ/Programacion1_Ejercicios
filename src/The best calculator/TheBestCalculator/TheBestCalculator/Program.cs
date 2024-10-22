using static System.Console;
List<decimal> typedNumbers = new List<decimal>();

decimal result = 0;
int typedOption = 1;
int wantToContinue = 0;
int index = 2;





Console.WriteLine("This is the best calculator");

Console.WriteLine("Please Type the option number than you want");
Console.WriteLine("---------------------------------------");
Console.WriteLine("1. Sum, \n 2. Substract,  \n 3. Multiplication,  \n 4. Division,  \n 5. Exit");

try
{
    typedOption = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please Type the first number");
    //typedNumbers[0] = Convert.ToDecimal(Console.ReadLine());
    typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

    Console.WriteLine("Please Type the second number");
    // typedNumbers[1] = Convert.ToDecimal(Console.ReadLine());
    typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));


   
    while (wantToContinue != 2)
    {
        Console.WriteLine("you want to continue inserting numbers? 1. Yes, 2. No");
        wantToContinue = Convert.ToInt32(Console.ReadLine());
        if (wantToContinue == 1)
        {
            ////typedNumbers = new decimal[index + 1];
            //int quantityElementsInTheArray = typedNumbers.Length + 1;
            int quantityElementsInTheArray = typedNumbers.Count + 1;
            //var oldTypedNumbers = typedNumbers;
            //typedNumbers = new decimal[quantityElementsInTheArray];

            //for (int i = 0; i < oldTypedNumbers.Length; i++)
            //{
            //    typedNumbers[i] = oldTypedNumbers[i]; 
            //}
            Console.WriteLine("Please Type another number");
            //typedNumbers[index] = Convert.ToDecimal(Console.ReadLine());
            typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));
            ////index = index + 1;
            ////index += 1;
            //index++;
        }
    }

    switch (typedOption)
    {
        case 1:
            {
                //for (int i = 0; i < typedNumbers.Length; i++)
                //{
                //    //result = result + typedNumbers[i];
                //    result += typedNumbers[i];
                //}
                foreach (int typedNumber in typedNumbers)
                {
                    result += typedNumber;
                }
            }
            break;
        case 2:
            foreach (int typedNumber in typedNumbers)
            {
                result -= typedNumber;
            }

            break;
        case 3:
            foreach (int typedNumber in typedNumbers)
            {
                result *= typedNumber;
            }

            break;
        case 4:
            foreach (int typedNumber in typedNumbers)
            {
                result /= typedNumber;
            }
            break;
        default:
            result = 0;
            break;
    }

    Console.WriteLine($"The Result of the operation is:{result}");

    //else
    //{ 

    //}
    //else 
    //{

    //    if (wantToContinue == 2)
    //    {
    //    }
    //   else
    //   {
    //   }
    //}



}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"you can not divide by zero: {ex.Message}");
}
catch (ArithmeticException ex)
{
    Console.WriteLine($"you can not divide by zero: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"You need to choose a correct option: {ex.Message}");
}
finally
{
    Console.WriteLine("Closing Db Conection");
}