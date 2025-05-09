using System;
using System.IO;

namespace A8.OOCalculator
{
    public abstract class UnaryOperator: Expression, IOperator
    {
        protected Expression Operand;

        public UnaryOperator()
        {
        }

        public UnaryOperator(TextReader reader)
        {
            Operand=BuildExpressionTree((StreamReader)reader);
        }
        

        public sealed override string ToString() =>$"{this.OperatorSymbol}({this.Operand.ToString()})";

        public abstract string OperatorSymbol { get; }
    }
}