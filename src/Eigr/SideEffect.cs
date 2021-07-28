namespace Eigr
{
    public class SideEffect
    {
        public string ServiceName { get; private set; }
        public string CommandName { get; private set; }
        public object Payload { get; private set; }

        public SideEffect() { }
        
        public SideEffect(string serviceName, string commandName, object payload)
        {
            ServiceName = serviceName;
            CommandName = commandName;
            Payload = payload;
        }
    }
}