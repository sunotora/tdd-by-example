﻿using System;

namespace TDDbyExample
{
    public class Sum : Expression
    {
        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Reduce(Bank bank,string to)
        {
            var amount = Augend.Amount + Addend.Amount;
            return new Money(amount, to);
        }

        public Money Augend { get; }
        public Money Addend { get; }
    }
}