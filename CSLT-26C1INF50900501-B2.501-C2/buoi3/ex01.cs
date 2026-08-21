internal class Program
{
    private static void Main(string[] args)
    {
        // convert from degrees Celsius to Kelvin and
        // Fahrenheit.
        Console.WriteLine("celsius :");
        double c = Convert.ToDouble(Console.ReadLine());
        double k = c + 273;
        double f = Math.Round(c * 1.8 + 32);
        Console.WriteLine($"fahrenheit: {f} ");
        Console.WriteLine($"kelvin : {k}");

        //calculate the surface and volume of a sphere
        Console.WriteLine(" radius :");
        double r = Convert.ToDouble(Console.ReadLine());
        double s = 4 * Math.PI * Math.Pow(r, 2);
        double v = 4 / 3 * Math.PI * Math.Pow(r, 3);
        Console.WriteLine($" surface: {s} ");
        Console.WriteLine($" volume : {v} ");

        //calculates the result
        Console.WriteLine("enter number 1 :");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter number 2 :");
        int b = Convert.ToInt32(Console.ReadLine());
        int plus = a + b;
        int minus = a - b;
        int mul = a * b;
        int dev = a / b;
        int mod = a % b;
        Console.WriteLine($"{a} + {b} = {plus}");
        Console.WriteLine($"{a} - {b} = {minus}");
        Console.WriteLine($"{a} * {b} = {mul}");
        Console.WriteLine($"{a} : {b} = {dev}");
        Console.WriteLine($"{a} mod {b} = {mod}");




        Console.ReadKey();
    }
}