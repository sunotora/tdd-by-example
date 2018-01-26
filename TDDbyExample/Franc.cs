using System;

namespace TDDbyExample
{
    public class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount, currency) { }

        public override Money Times(int multiplier)
        {
            return new Franc(amount * multiplier, "CHF");
        }
    }
}
