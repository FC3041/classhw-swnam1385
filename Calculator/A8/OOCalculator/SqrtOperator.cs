using System;
using System.IO;

namespace A8.OOCalculator
{
    public class SqrtOperator : UnaryOperator
    {
        public SqrtOperator(TextReader reader)
            :base(reader)
        {
            // GetNextExpression(reader);
        }

        public override string OperatorSymbol => "Sqrt";

        public override double Evaluate() =>Math.Sqrt(Operand.Evaluate());
    }
}