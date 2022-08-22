using System;
namespace StaticExercise
{   //create a static class called TempConverter
    public static class TempConverter
    {
        //create 2 methods, one called FahrenheitToCelsius that will require
        //a double as a parameter and return a double,
        //the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.
        public static double FahrenheitToCelsius (double degree)
        {
            return (degree - 32) / 1.8;
        }

        public static double CelsiusToFahrenheit (double degree)
        {
            return (degree * 9) / 5 + 32;
        }
    }
}

