namespace Fundamentos;

class Program
{
    static void Main()
    {
        // Integral numeric
        int intNumber = 7;
        long longNumber = 145021;
        uint uintNumber = 12;

        // Floating-point
        double doubleNumber = 3.14;
        float floatNumber = 3.14f;
        decimal decimalNumber = 3.14m;
        
        // Boolean
        bool active = true;
        
        // Char
        char letter = 'A'; // single quotes
        
        // String
        string name = "Vegeta"; // double quotes

        char firstLetter = name[0];
        
        Console.WriteLine(firstLetter);
        
        Console.WriteLine(doubleNumber);
        Console.WriteLine(doubleNumber.GetType().Name);
    }
}

