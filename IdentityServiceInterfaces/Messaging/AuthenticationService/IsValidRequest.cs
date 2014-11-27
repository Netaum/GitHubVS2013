using System;
using System.Runtime.Serialization;
using IdentityServiceInterfaces.DTO;

namespace IdentityServiceInterfaces.Messaging.AuthenticationService
{
    [DataContract, Serializable]
    public class IsValidRequest
    {
        [DataMember]
        public Session Session { get; set; }
    }
}
