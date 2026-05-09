namespace logic_gates.Models
{
    public abstract class ComponentBase
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool Output { get; set; } = false;
        public IList<bool> Connections { get; } = [];
        public short MaxInputs { get; set; }
    }
}
