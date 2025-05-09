namespace A8.StatePattern
{
    /// <summary>
    /// ماشین حساب وقتی که جواب یک محاسبه
    /// را نشان میدهد وارد این وضعیت میشود
    /// </summary>
    public class ComputeState : CalculatorState
    {
        public ComputeState(Calculator calc) : base(calc) { }

        public override IState EnterEqual()
        {
            Calc.DisplayError("Syntax Error");
            return new ErrorState(this.Calc);
        }

        public override IState EnterNonZeroDigit(char c)
        {
            // #3 لطفا!
            // when we want to calculate something we use this function to find second number and it`s first digit must be !=0
            this.Calc.Display =c.ToString();
            return new AccumulateState(this.Calc);
        }

        public override IState EnterZeroDigit()
        {
            // #4 لطفا
            // if the first digit of the second number in calculation is 0 pragram came into this function 
            //because 0 as first digit in number doesn`t have effect 
            this.Calc.Display ="0";
            return new StartState(this.Calc);

        }

        
        public override IState EnterOperator(char c)
        {
            // #5 لطفا
            // this function is using to find the operator between numbers and use pending operator at evaluate() 
            // to calculate accoulation
            Calc.PendingOperator =c;
            return this;
        }

        public override IState EnterPoint()
        {
            Calc.Display = "0.";
            return new PointState(this.Calc);
        }

    }
}