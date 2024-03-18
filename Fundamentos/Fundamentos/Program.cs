namespace Fundamentos;

class Program
{
    static void Main()
    {
        int intNumber = 7;
        long longNumber = 145021;
        uint uintNumber = 12;

        double doubleNumber = 3.14;
        float floatNumber = 3.14f;
        decimal decimalNumber = 3.14m;
        
        Console.WriteLine(doubleNumber);
        Console.WriteLine(doubleNumber.GetType().Name);
    }
}

