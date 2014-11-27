using System;
using System.Runtime.Serialization;
using IdentityServiceInterfaces.Messaging.Base;

namespace IdentityServiceInterfaces.Messaging.AuthenticationService
{
    [DataContract, Serializable]
    public class SignOutRequest:RequestBase
    {
       
    }
}
