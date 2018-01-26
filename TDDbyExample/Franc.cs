using System;

namespace TDDbyExample
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            this.amount = amount;
            currency = "CHF";
        }

        public override Money Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }
    }
}
