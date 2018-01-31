using System;

namespace TDDbyExample
{
    public class Money : Expression
    {
        int amount;
        string currency;

        public int Amount => amount;
        public string Currency => currency;

        public Money (int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public Money Reduce(string to)
        {
            return this;
        }

        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

        public Expression Plus(Money addend)
        {
            return new Sum(this, addend);
        }

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return Currency == money.Currency
                && amount == money.amount;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }
    }
}
