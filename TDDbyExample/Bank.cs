using System;

namespace TDDbyExample
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            var money = source as Money;
            if (money != null) return money;
            var sum = (Sum)source;
            return sum.Reduce(to);
        }
    }
}