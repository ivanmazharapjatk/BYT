using BYT_PartTwo;
try
{
    Calculator calc1 = new Calculator(10, 5, '+');
    Console.WriteLine("10 + 5 = " + calc1.Compute());

    Calculator calc2 = new Calculator(20, 4, '*');
    Console.WriteLine("20 * 4 = " + calc2.Compute());

    Calculator calc3 = new Calculator(8, 2, '/');
    Console.WriteLine("8 / 2 = " + calc3.Compute());
    
    Calculator calc4 = new Calculator(8, 0, '/');
    Console.WriteLine("8 / 0 = " + calc4.Compute());
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}