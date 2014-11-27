using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace IdentityServiceInterfaces.DTO
{
    [DataContract, Serializable]
    public class Role
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public bool IsAdministrativeRole { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public IEnumerable<Right> Rights { get; set; }
    }
}
