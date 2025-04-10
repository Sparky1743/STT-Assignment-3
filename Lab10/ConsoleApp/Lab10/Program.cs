class Program
{
    //static void Main()
    //{
    //    // Create an instance of the Calculator class
    //    Calculator calculator = new Calculator();

    //    Console.Write("Enter first number: ");
    //    int num1 = Convert.ToInt32(Console.ReadLine());

    //    Console.Write("Enter second number: ");
    //    int num2 = Convert.ToInt32(Console.ReadLine());

    //    int sum = calculator.Add(num1, num2);
    //    Console.WriteLine($"Addition: {sum}");
    //    Console.WriteLine($"Subtraction: {calculator.Subtract(num1, num2)}");
    //    Console.WriteLine($"Multiplication: {calculator.Multiply(num1, num2)}");
    //    Console.WriteLine($"Division: {calculator.Divide(num1, num2)}");

    //    Console.WriteLine(calculator.CheckSumParity(sum));
    //}

    static void Main()
    {
        // Print numbers from 1 to 10
        Console.WriteLine("Numbers from 1 to 10:");
        LoopFunctionDemo.PrintNumbers();

        // While loop to take user input until "exit" is entered
        string input;
        do
        {
            Console.Write("Enter a number to calculate factorial (or type 'exit' to stop): ");
            input = Console.ReadLine();

            if (input.ToLower() != "exit")
            {
                if (int.TryParse(input, out int num) && num >= 0)
                {
                    Console.WriteLine($"Factorial of {num} is: {LoopFunctionDemo.Factorial(num)}");
                }
                else
                {
                    Console.WriteLine("Please enter a valid non-negative integer.");
                }
            }
        } while (input.ToLower() != "exit");
    }

    // Main method for testing Student class
    //static void Main()
    //{
    //    Student student1 = new Student("Alice", 101, 85);
    //    student1.DisplayStudentDetails();

    //    // Creating an instance of StudentIITGN
    //    StudentIITGN student2 = new StudentIITGN("Bob", 102, 92, "Kyzeel");
    //    student2.DisplayStudentDetails();
    //}

    //static void Main()
    //{
    //    Calculator calculator = new Calculator();

    //    try
    //    {
    //        Console.Write("Enter first number: ");
    //        int num1 = Convert.ToInt32(Console.ReadLine());

    //        Console.Write("Enter second number: ");
    //        int num2 = Convert.ToInt32(Console.ReadLine());

    //        int sum = calculator.Add(num1, num2);
    //        Console.WriteLine($"Addition: {sum}");
    //        Console.WriteLine($"Subtraction: {calculator.Subtract(num1, num2)}");
    //        Console.WriteLine($"Multiplication: {calculator.Multiply(num1, num2)}");
    //        Console.WriteLine($"Division: {calculator.Divide(num1, num2)}");

    //        Console.WriteLine(calculator.CheckSumParity(sum));
    //    }
    //    catch (FormatException)
    //    {
    //        Console.WriteLine("Invalid input. Please enter a valid integer.");
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
    //    }
    //}

}