using System;

namespace TDDbyExample
{
    public abstract class Money
    {
        protected int amount;
        protected string currency;

        public string Currency => currency;

        public abstract Money Times(int multiplier);

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return GetType() == money.GetType()
                && amount == money.amount;
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }
    }
}
