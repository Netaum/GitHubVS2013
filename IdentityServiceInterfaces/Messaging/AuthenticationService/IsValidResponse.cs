using System;
using System.Runtime.Serialization;

namespace IdentityServiceInterfaces.Messaging.AuthenticationService
{
    [DataContract, Serializable]
    public class IsValidResponse
    {
        [DataMember]
        public bool IsValid { get; set; }
    }
}
