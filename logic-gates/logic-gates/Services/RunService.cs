using logic_gates.Models;

namespace logic_gates.Services
{
    public class RunService
    {
        private readonly IDictionary<Identifier, ComponentBase> _components;
        private readonly IDictionary<Identifier, Connection> _connections;

        public RunService()
        {
            _components = new Dictionary<Identifier, ComponentBase>();
            _connections = new Dictionary<Identifier, Connection>();
        }
    }
}
