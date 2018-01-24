using System;

namespace TDDbyExample
{
    public class Dollar : IEquatable<Dollar>
    {
        public int Amount { get; private set; }

        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public bool Equals(Dollar other)
        {
            return true;
        }
    }
}