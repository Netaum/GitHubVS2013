using System;
using System.Runtime.Serialization;
using IdentityServiceInterfaces.DTO;

namespace IdentityServiceInterfaces.Messaging.AuthorizationService
{
    [DataContract, Serializable]
    public class GetAllRolesRequest
    {
        public Session Session { get; set; }
    }
}
