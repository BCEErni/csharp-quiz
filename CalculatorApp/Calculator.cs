using System.Security.Cryptography.X509Certificates;

namespace CalculatorApp;

public class Calculator
{
    public double PerformOperation(double num1, double num2, string operation)
    {
        double result = 0;
        

        if(operation == "add")
        {
          result =  num1 + num2;
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
                    throw new DivideByZeroException();
                }
          
            result = num1/num2;
        }
        else {
            throw new InvalidOperationException();
        }
        
        // TODO: Implement the PerformOperation method
      
    return result;
    }

    public double AddSum(double num1, double num2)
    {
         return num1+num2;
    }
     public double Subtract(double num1, double num2)
    {
         return num1-num2;
    }
     public double Product(double num1, double num2)
    {
         return num1*num2;
    }
     public double Quotient(double num1, double num2)
    {
         return num1/num2;
    }
}