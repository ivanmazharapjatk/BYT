namespace BYT_PartTwo;

public class Calculator
{
    private double a;
    private double b;
    private char operation;
    
    public Calculator(double a, double b, char operation)
    {
        this.a = a;
        this.b = b;
        this.operation = operation;
    }
    
    public double Compute()
    {
        return operation switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => b == 0 
                ? throw new DivideByZeroException("Cannot divide by zero.") 
                : a / b,
            _   => throw new InvalidOperationException($"Invalid operation: {operation}")
        };
    }
}