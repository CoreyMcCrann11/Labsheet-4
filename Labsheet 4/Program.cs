using System;

namespace Labsheet_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar;
            myCar = new Car();

            myCar.Make = "Ford";

            myCar.Model = "Focus";

            myCar.currentSpeed = "120Mph";

            myCar.engineSize = "1.5L";

            Console.WriteLine(myCar.ToString());
        }
    }
}
