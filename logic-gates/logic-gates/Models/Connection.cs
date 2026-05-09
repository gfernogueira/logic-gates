namespace logic_gates.Models
{
    public class Connection
    {
        public ComponentBase Input { get; set; }
        public ComponentBase Output { get; set; }

        public Connection(ComponentBase input, ComponentBase output)
        {
            Input = input;
            Output = output;
        }
    }
}
