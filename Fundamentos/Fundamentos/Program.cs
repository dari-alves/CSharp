namespace Fundamentos;

class Program
{
    static void Main()
    {
        // array
        int[] integers = new int[10];
        float[] floats = [3.14f, 5.25f];

        integers[0] = 1;
        
        // list
        List<int> listIntegers = new List<int>();
        
        listIntegers.Add(1);
        listIntegers.Add(2);
        listIntegers.Add(3);
        
        // listIntegers.RemoveAt(0);
        listIntegers.Clear();
        
        Console.WriteLine(listIntegers.Count);
    }
}

