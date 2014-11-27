using System;
using System.Runtime.Serialization;

namespace IdentityServiceInterfaces.Messaging.AuthorizationService
{
    [DataContract, Serializable]
    public class IsAuthorizedResponse
    {
        [DataMember]
        public bool IsAuthorized { get; set; }
    }
}
