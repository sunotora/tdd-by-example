using System;

namespace TDDbyExample
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Money Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}