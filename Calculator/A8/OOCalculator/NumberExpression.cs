using System;
using System.IO;

namespace A8.OOCalculator
{
    public class NumberExpression : Expression
    {
        protected double Number;

        public NumberExpression(string line)
        {
            this.Number = double.Parse(line);
        }

        public override double Evaluate() => Number;

        public override string ToString() => Number.ToString();
    }
}