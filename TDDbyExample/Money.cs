﻿using System;

namespace TDDbyExample
{
    public class Money
    {
        protected int amount;
        protected string currency;

        public Money (int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public string Currency => currency;

        public virtual Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return Currency == money.Currency
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
