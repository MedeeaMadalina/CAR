using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CAR
{
    public class Car
    {
        public string color;
        public string name;
        public int maxSpeed;
        public int year;
        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue)
        {
            name = nameName;
            color = colorName;
            year = yearValue;
            maxSpeed = maxSpeedValue;
        }
        public Car(string nameName)
        {

        }
        public void fullThrottle()
        {
            Console.WriteLine(name + “ is going at the speed of “ +maxSpeed);
        }

    }

}

