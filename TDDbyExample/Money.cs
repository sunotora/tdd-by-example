using System;

namespace TDDbyExample
{
    public class Money : IEquatable<Money>
    {
        protected int amount;
        public bool Equals(Money other)
        {
            return amount == other.amount;
        }
    }
}
