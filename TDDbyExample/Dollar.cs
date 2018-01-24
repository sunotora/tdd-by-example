using System;

namespace TDDbyExample
{
    public class Dollar : Money, IEquatable<Dollar>
    {
        int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        public bool Equals(Dollar other)
        {
            return amount == other.amount;
        }
    }
}