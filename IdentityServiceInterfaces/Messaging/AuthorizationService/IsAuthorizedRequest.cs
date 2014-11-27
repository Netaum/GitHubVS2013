using System;
using System.Runtime.Serialization;
using IdentityServiceInterfaces.DTO;

namespace IdentityServiceInterfaces.Messaging.AuthorizationService
{
    [DataContract, Serializable]
    public class IsAuthorizedRequest
    {
        [DataMember]
        public Session Session { get; set; }

        [DataMember]
        public Right Right { get; set; }
    }
}
