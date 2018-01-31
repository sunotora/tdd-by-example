using System;
using System.Collections.Generic;

namespace TDDbyExample
{
    public class Bank
    {
        Dictionary<Pair, int> rates = new Dictionary<Pair, int>();
        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }

        public int Rate(string from, string to)
        {
            if (from == to) return 1;
            return rates[new Pair(from, to)];
        }
    }
}