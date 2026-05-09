namespace logic_gates.Models
{
    public class TruthTable
    {
        public IList<TruthValue> Values { get; } = [];
        public short InputCount { get; set; }

        public TruthTable(short inputCount)
        {
            InputCount = inputCount;
        }
    }
}
