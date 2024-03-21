namespace Fundamentos;

class Data2
{
    public enum DifficultyLevel
    {
        Easy = 0,
        Normal = 1,
        Hard = 2
    }

    DifficultyLevel level;
    
    // // Integral numeric
        // int intNumber = 7;
        // long longNumber = 145021;
        // uint uintNumber = 12;
        //
        // // Floating-point
        // double doubleNumber = 3.14;
        // float floatNumber = 3.14f;
        // decimal decimalNumber = 3.14m;
        //
        // // Boolean
        // bool active = true;
        //
        // // Char
        // char letter = 'A'; // single quotes
        //
        // // String
        // string name = "Vegeta"; // double quotes
        //
        // char firstLetter = name[0];
        //
        // Console.WriteLine(firstLetter);
        //
        // Console.WriteLine(doubleNumber);
        // Console.WriteLine(doubleNumber.GetType().Name);
        //
        // string path = @"C:\test"; // "C:\\test"
        //
        // string firstName = "Iori";
        // string lastName = "Yagami";
        //
        // string fullName = $"{firstName} {lastName}";
        //
        // // String Builder
        // StringBuilder stringBuilder = new StringBuilder();
        //
        // stringBuilder.Append(firstName);
        // stringBuilder.Append(lastName);
        //
        // string result = stringBuilder.ToString();
        //
        // string user = "Name: {0}. \nPassword: {1}";
        //
        // string userData = string.Format(user, "Vegeta", 8000);
        //
        // Console.WriteLine(userData);
        
        // Dates
       
        // DateOnly day = new DateOnly(2024, 3, 19);
        //
        // string dayInText = day.ToString(new CultureInfo("en-US"));
        //
        // DateTime today = DateTime.UtcNow;
        //
        // DateTime tomorrow = today.AddDays(1);
        //
        // Console.WriteLine(dayInText);
        // Console.WriteLine(today);
        // Console.WriteLine(tomorrow);

        // Data2 data = new Data2();
        //
        // Console.WriteLine("Level: " + Data2.DifficultyLevel.Easy + " Level Int: " + (int)Data2.DifficultyLevel.Easy);
        // Console.WriteLine("Level: " + Data2.DifficultyLevel.Normal + " Level Int: " + (int)Data2.DifficultyLevel.Normal);
        // Console.WriteLine("Level: " + Data2.DifficultyLevel.Hard + " Level Int: " + (int)Data2.DifficultyLevel.Hard);
        //
        // // var
        // var name2 = "Son Goku";
        //
        // // object
        // object name3 = "Kuririn";
        //
        // // null
        // int? age = null;
        //
        // bool informedAge = age.HasValue;
        //
        // Console.WriteLine(informedAge);
}