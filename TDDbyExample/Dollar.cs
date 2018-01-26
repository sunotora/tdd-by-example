using System;

namespace TDDbyExample
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.amount = amount;
            currency = "USD";
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}