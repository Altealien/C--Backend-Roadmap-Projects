//Advanced operations like(Power, Square Root, Percentage)

/*For the operations set limitations to how they can be performed
i.e Let the user know that it's(+,-,/,*, ^- for power ¬ for square root and % for percentage*/
//Use split the string to separate the input, ensure the user properly spaces them out
//e.g 10 + 30 
//Handles division by zero(exception handling)
//Validates user input(ensures user is entering digits. Scope: ints, floats, doubles, long)
//Allows continuous calculation till user exits

// Create methods for all arithmetic operations

// 
using System.Data;




Queue<double?> calculationHistory = []; ;

CalculatorDisplay();

double PerfomCalculations()
{
    Console.Write("Enter expression(e.g 10 + 10): ");
    string expression = Console.ReadLine() ?? string.Empty;
    object result = new DataTable().Compute(expression, null);
    double calculationResult = Convert.ToDouble(result);
    if (calculationHistory.Count < 5)
    {
        calculationHistory.Enqueue(calculationResult);
    }
    else
    {
        calculationHistory.Dequeue();
        calculationHistory.Enqueue(calculationResult);
    }

    return calculationResult;

}

void CalculatorDisplay()
{
    bool looping = true;
    while (looping)
    {
        try
        {
            MainMenu();
            Console.Write("Enter your choice: ");
            string? input = Console.ReadLine() ?? string.Empty;
            {
                switch (input)
                {
                    case "1":
                        //Perform Calculations
                        Console.WriteLine("Performing calculations...\nSeparate each value with space.");
                        Console.WriteLine(PerfomCalculations());
                        Console.WriteLine();
                        break;
                    case "2":
                        //View Calculation History
                        Console.WriteLine("Showing calculation history(last 5 results)");
                        double?[] itemsArray = calculationHistory.ToArray();
                        Array.Reverse(itemsArray);
                        foreach (var item in itemsArray)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine();
                        break;
                    case "3":
                        looping = false;
                        break;
                    default:
                        throw new ArgumentException("Invalid choice. Try again.");
                }
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine();
        }
    }
    Console.Write("Press any key to exit...");
    Console.ReadKey();
}

void MainMenu()
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Perform calculations.");
    Console.WriteLine("2. View calculation history.");
    Console.WriteLine("3. Exit.");
}