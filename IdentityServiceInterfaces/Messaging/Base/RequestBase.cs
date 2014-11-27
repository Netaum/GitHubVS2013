using System;
using System.Runtime.Serialization;
using IdentityServiceInterfaces.DTO;

namespace IdentityServiceInterfaces.Messaging.Base
{
    [DataContract, Serializable]
    public class RequestBase
    {
        [DataMember]
        public Session Session { get; set; }
    }
}
