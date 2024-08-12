namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
  {
    try
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
        string operation = Console.ReadLine()?.ToLower() ?? string.Empty;

        var calculator = new Calculator();    
        double result = calculator.PerformOperation(num1, num2, operation);
        Console.WriteLine($"The result is: {result}");

       
    }
    catch(DivideByZeroException) //Division by zero
    {
        Console.WriteLine("Cannot Divide by zero");

    }
    catch(FormatException) //Invalid input (Non-numeric value)
    {
        Console.WriteLine("Invalid input, Please enter numeric values");
    }
    catch (InvalidOperationException) // (Unsupported Operation)
    {
        Console.WriteLine("An error occured: The specified operation is not supported.");
    }
    finally
    {
        Console.WriteLine("Calculation attempt finished");
    }
    }
  
}