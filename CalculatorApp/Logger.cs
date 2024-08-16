using System;
using Microsoft.Extensions.Logging;

namespace CalculatorApp
{
    public class Logger
    {
        private readonly ILogger<Calculator> _logger;

        public Logger(ILogger<Calculator> logger)
        {
            _logger = logger;
        }

        public double PerformOperation(double num1, double num2, string operation)
        {
            double result = 0;

            try
            {
                _logger.LogInformation("Performing operation: {Operation} with numbers {Num1} and {Num2}", operation, num1, num2);

                if (operation == "add")
                {
                    result = num1 + num2;
                }
                else if (operation == "subtract")
                {
                    result = num1 - num2;
                }
                else if (operation == "multiply")
                {
                    result = num1 * num2;
                }
                else if (operation == "divide")
                {
                    if (num2 == 0)
                    {
                        _logger.LogError("Attempted to divide by zero.");
                        throw new DivideByZeroException();
                    }

                    result = num1 / num2;
                }
                else
                {
                    _logger.LogError("Invalid operation: {Operation}", operation);
                    throw new InvalidOperationException();
                }

                _logger.LogInformation("Operation result: {Result}", result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while performing the operation.");
                throw;
            }

            return result;
        }

        public double AddSum(double num1, double num2)
        {
            _logger.LogInformation("Adding {Num1} and {Num2}", num1, num2);
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            _logger.LogInformation("Subtracting {Num2} from {Num1}", num1, num2);
            return num1 - num2;
        }

        public double Product(double num1, double num2)
        {
            _logger.LogInformation("Multiplying {Num1} and {Num2}", num1, num2);
            return num1 * num2;
        }

        public double Quotient(double num1, double num2)
        {
            if (num2 == 0)
            {
                _logger.LogError("Attempted to divide by zero.");
                throw new DivideByZeroException();
            }

            _logger.LogInformation("Dividing {Num1} by {Num2}", num1, num2);
            return num1 / num2;
        }
    }
}