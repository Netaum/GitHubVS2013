using System;
using System.Runtime.Serialization;
using IdentityServiceInterfaces.Messaging.Base;

namespace IdentityServiceInterfaces.Messaging.AuthorizationService
{
    [DataContract, Serializable]
    public class GetAllRolesRequest:RequestBase
    {
    }
}
