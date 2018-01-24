﻿using System;

namespace TDDbyExample
{
    public class Dollar
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
    }
}