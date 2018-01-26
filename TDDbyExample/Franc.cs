﻿using System;

namespace TDDbyExample
{
    public class Franc : Money
    {
        public Franc(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.Franc(amount * multiplier);
        }
    }
}
