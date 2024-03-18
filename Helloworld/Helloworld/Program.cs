using Helloworld;
using Helloworld.Test;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        Car myCar = new Car(); 

        myCar.TurnOn();

        myCar.TurnOff();

        Thermometer myThermometer = new Thermometer();

        myThermometer.Temperature();

        myCar.Test2();

    }
}