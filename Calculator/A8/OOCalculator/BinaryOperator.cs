using System;
using System.IO;

namespace A8.OOCalculator
{
    public abstract class BinaryOperator: Expression, IOperator
    {
        protected Expression LHS;
        protected Expression RHS;

        public BinaryOperator()
        {
        }

        public BinaryOperator(TextReader reader)
        {
            LHS=BuildExpressionTree((StreamReader)reader);
            RHS=BuildExpressionTree((StreamReader)reader);
        }

        public abstract string OperatorSymbol { get; }

        public sealed override string ToString() => $"({this.LHS}{this.OperatorSymbol}{this.RHS})";

    }
}