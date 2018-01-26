using System;

namespace TDDbyExample
{
    public class Franc : Money
    {
        string currency;
        public Franc(int amount)
        {
            this.amount = amount;
            currency = "CHF";
        }

        public override string Currency => currency;

        public override Money Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }
    }
}
