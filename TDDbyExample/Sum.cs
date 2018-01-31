using System;

namespace TDDbyExample
{
    public class Sum : Expression
    {
        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Augend { get; }
        public Money Addend { get; }
    }
}