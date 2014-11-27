using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using IdentityServiceInterfaces.DTO;

namespace IdentityServiceInterfaces.Messaging.AuthorizationService
{
    [DataContract, Serializable]
    public class GetAllRolesResponse
    {
        [DataMember]
        public IEnumerable<Role> Roles { get; set; }
    }
}
