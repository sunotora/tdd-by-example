using System;

namespace TDDbyExample
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            var sum = (Sum)source;
            var amount = sum.Augend.Amount + sum.Addend.Amount;
            return new Money(amount, to);
        }
    }
}