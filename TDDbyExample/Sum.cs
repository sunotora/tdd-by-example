using System;

namespace TDDbyExample
{
    public class Sum : Expression
    {
        public Expression Augend { get; }
        public Expression Addend { get; }

        public Sum(Expression augend, Expression addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Expression Plus(Expression addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank,string to)
        {
            var amount = Augend.Reduce(bank, to).Amount + Addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }
    }
}