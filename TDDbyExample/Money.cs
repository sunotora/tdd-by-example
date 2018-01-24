using System;

namespace TDDbyExample
{
    public class Money
    {
        protected int amount;
        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return GetType() == money.GetType()
                && amount == money.amount;
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }
    }
}
