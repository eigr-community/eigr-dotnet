namespace Eigr
{
    public class EntitySpec
    {
        public string ServiceName { get; private set; }
        public Entity[] Entities { get; private set; }
        public int Port { get; private set; }

        public EntitySpec() { }
        
        public EntitySpec(string serviceName, Entity[] entities, int port)
        {
            ServiceName = serviceName;
            Entities = entities;
            Port = port;
        }
    }
}