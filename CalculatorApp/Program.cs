using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up dependency injection and logging
            var serviceProvider = new ServiceCollection()
                .AddLogging(configure => configure.AddConsole())
                .AddTransient<Calculator>()
                .BuildServiceProvider();

            var logger = serviceProvider.GetService<ILogger<Program>>();
            var calculatorLogger = serviceProvider.GetService<ILogger<Calculator>>();
            var calculator = new Logger(calculatorLogger);

            try
            {
                logger.LogInformation("Starting the calculator application.");

                Console.WriteLine("Enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
                string operation = Console.ReadLine()?.ToLower() ?? string.Empty;

                double result = calculator.PerformOperation(num1, num2, operation);
                Console.WriteLine($"The result is: {result}");
            }
            catch (DivideByZeroException)
            {
                logger.LogError("Cannot divide by zero.");
                
            }
            catch (FormatException)
            {
                logger.LogError("Invalid input, please enter numeric values.");
                
            }
            catch (InvalidOperationException)
            {
                logger.LogError("The specified operation is not supported.");
                
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An unexpected error occurred.");
                
            }
            finally
            {
                logger.LogInformation("Calculation attempt finished.");
                
            }
        }
    }
}