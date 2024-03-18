namespace Helloworld;
class Car
{
    public void TurnOn()
    {
        Console.WriteLine("Car turned on");
    }

    public void TurnOff()
    {
        Console.WriteLine("Car turned off");
    }

    private void Test1()
    {
        Console.WriteLine("Test 1");
    }

    internal void Test2()
    {
        Console.WriteLine("Test 2");
    }
}
