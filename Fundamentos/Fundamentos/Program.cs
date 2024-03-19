using System.Text;

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

        string path = @"C:\test"; // "C:\\test"

        string firstName = "Iori";
        string lastName = "Yagami";

        string fullName = $"{firstName} {lastName}";
        
        // String Builder
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append(firstName);
        stringBuilder.Append(lastName);

        string result = stringBuilder.ToString();

        string user = "Name: {0}. \nPassword: {1}";

        string userData = string.Format(user, "Vegeta", 8000);
        
        Console.WriteLine(userData);
    }
}

