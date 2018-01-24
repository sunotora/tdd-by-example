﻿using System;

namespace TDDbyExample
{
    public class Franc : IEquatable<Franc>
    {
        int amount;

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
