using static System.Console;

namespace A8.StatePattern
{
    public class AccumulateState : CalculatorState
    {
        public AccumulateState(Calculator calc) : base(calc) { }

        
        public override IState EnterEqual()
        {
            // #7 لطفا
            // this func is used when we enter '=' and calculate the result by processed operator
            return ProcessOperator(new ComputeState(this.Calc));
        }
        public override IState EnterZeroDigit() => EnterNonZeroDigit('0');
        public override IState EnterNonZeroDigit(char c)
        {
            // #8 لطفا!
            // add digit as char to display and finally we have our number to string 
            this.Calc.Display+=c.ToString();
            return new AccumulateState(Calc);
        }

        // #9 لطفا!
        //we use it to 
        public override IState EnterOperator(char c) 
        {
            this.Calc.Evalute();
            return new ComputeState(this.Calc);
        }

        public override IState EnterPoint()
        {
            // #10 لطفا!
            // We use this function to assure we can use '.' just once and if user enter '.' rapidly doesn`t have effect in our number
            PointState sum = new PointState(this.Calc);
            if (Calc.Display.Contains('.'))
            {
                return sum;
            }
            sum.EnterNonZeroDigit('.');
            return sum;
        }
    }
}