using System;

namespace TDDbyExample
{
    public class Franc : Money, IEquatable<Franc>
    {
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

        public bool Equals(Franc other)
        {
            return amount == other.amount;
        }
    }
}
