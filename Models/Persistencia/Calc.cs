using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDotNet.Models.Persistencia
{
    internal class Calc
    {
        public static int Sum(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
        public static int Sub(int number1, int number2)
        {
            int result = number1 - number2;
            return result;
        }
        public static Double Div(Double number1, Double number2)
        {
            Double result = number1 / number2;
            return result;
        }
        public static int Multi(int number1, int number2)
        {
            int result = number1 * number2;
            return result;
        }
    }
}
