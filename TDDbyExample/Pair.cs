namespace TDDbyExample
{
    class Pair
    {
        string from;
        string to;
        public Pair(string from, string to)
        {
            this.from = from;
            this.to = to;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Pair;
            if (other == null) return false;
            return from == other.from && to == other.to;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
