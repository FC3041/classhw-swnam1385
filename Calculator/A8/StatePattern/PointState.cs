﻿namespace A8.StatePattern
{
    /// <summary>
    /// این وضعیت نشان دهنده حالتی است که نقطه زده شده
    /// این وضعیت شبیه وضعیت
    /// Accumulate
    /// است
    /// تنها فرقش این است که نقطه جدیدی نمی شود زد.
    /// تغییرات لازم را برای این کار بدهید.
    /// </summary>
    public class PointState : AccumulateState
    {
        public PointState(Calculator calc) : base(calc) 
        {
        }
        public override IState EnterNonZeroDigit(char c)
        {
            this.Calc.Display += c.ToString();
            return this;
        }
        //#1 لطفا!
        // we use this class to make Decimals number 
        // EnterNonZeroDigit work in this class to add '.' to calc.display
    }
}