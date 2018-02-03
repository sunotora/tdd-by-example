namespace TDDbyExample
{
    public interface Expression
    {
        Expression Plus(Expression addend);
        Expression Times(int multiplier);
        Money Reduce(Bank bank, string to);
    }
}