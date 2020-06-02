using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDotNet.Models
{
    public class Calc
    {
        private int number1;
        private int number2;
        private int result;

        public int Number1 { get => number1; set => number1 = value; }
        public int Number2 { get => number2; set => number2 = value; }
        public int Result { get => result; set => result = value; }

        public int Sum(int number1, int number2) => Persistencia.Calc.Sum(number1, number2);
        public int Sub(int number1, int number2) => Persistencia.Calc.Sub(number1, number2);
        public Double Div(Double number1, Double number2) => Persistencia.Calc.Div(Convert.ToDouble(number1), Convert.ToDouble(number2));
        public int Multi(int number1, int number2) => Persistencia.Calc.Multi(number1, number2);
    }
}
