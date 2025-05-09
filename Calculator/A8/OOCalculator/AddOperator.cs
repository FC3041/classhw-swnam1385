using System;
using System.IO;

namespace A8.OOCalculator
{
    public class AddOperator : BinaryOperator
    {
        public AddOperator(TextReader reader)
            :base(reader)
        {
            // GetNextExpression(reader);
        }

        public override string OperatorSymbol => "+";
        public override double Evaluate()
        {
            double result =RHS.Evaluate()+LHS.Evaluate();
            return result;
        }

    }
}