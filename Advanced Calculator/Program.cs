//Performs Basic Arithmetic Operations(+,-,*,/)
//Advanced operations like(Power, Square Root, Percentage)

/*For the operations set limitations to how they can be performed
i.e Let the user know that it's(+,-,/,*, ^- for power ¬ for squar root and % for percentage*/

//Stores calculation history(last 5 calculations(could be just the result alone or the actual calculation))
//Handles division by zero(exception handling)
//Validates user input(ensures user is entering digits. Scope: ints, floats, doubles, long)
//Allows continuous calculation till user exits- Done

// Create methods for all arithmetic operations
CalculatorDisplay();








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
                        Console.WriteLine("Performing calculations...");
                        Console.WriteLine();
                        break;
                    case "2":
                        //View Calculation History
                        Console.WriteLine("Showing calculation history");
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