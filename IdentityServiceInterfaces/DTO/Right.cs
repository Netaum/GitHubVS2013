using System;
using System.Runtime.Serialization;

namespace IdentityServiceInterfaces.DTO
{
    [DataContract, Serializable]
    public class Right
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Code { get; set; }
    }
}
