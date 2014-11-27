using System;
using System.Runtime.Serialization;

namespace IdentityServiceInterfaces.Messaging.AuthenticationService
{
    [DataContract, Serializable]
    public class SignInRequest
    {
        [DataMember]
        public string EMail { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string FingerTip { get; set; }
    }
}
