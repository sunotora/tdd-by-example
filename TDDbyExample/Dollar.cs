using System;

namespace TDDbyExample
{
    public class Dollar : Money
    {
        string currency;
        public Dollar(int amount)
        {
            this.amount = amount;
            currency = "USD";
        }

        public override string Currency => currency;

        public override Money Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}