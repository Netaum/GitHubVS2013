using System;
using System.Runtime.Serialization;

namespace IdentityServiceInterfaces.Messaging.AuthenticationService
{
    [DataContract, Serializable]
    public class SignOutResponse
    {
        [DataMember]
        public bool Success { get; set; }
    }
}
