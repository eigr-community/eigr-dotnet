using System;

namespace Eigr
{
    public class Entity
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Service { get; private set; }
        public string PersistenceId { get; private set; }
        public string Descriptor { get; private set; }
        public string[] AdditionalDescriptors { get; private set; }

        public Entity() {}
        
        public Entity(string name, string type, string service, string persistenceId, string descriptor, string[] additionalDescriptors)
        {
            Name = name;
            Type = type;
            Service = service;
            PersistenceId = persistenceId;
            Descriptor = descriptor;
            AdditionalDescriptors = additionalDescriptors;
        }
    }
}