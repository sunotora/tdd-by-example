﻿using System;

namespace TDDbyExample
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency) { }

        public override Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }
    }
}