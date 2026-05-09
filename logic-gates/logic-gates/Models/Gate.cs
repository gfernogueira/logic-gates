namespace logic_gates.Models
{
    public class Gate : ComponentBase
    {
        public TruthTable TruthTable { get; set; }

        public Gate()
        {
            TruthTable = new TruthTable(MaxInputs);
        }
    }
}
