﻿using System;
using System.Runtime.Serialization;
using IdentityServiceInterfaces.DTO;
using IdentityServiceInterfaces.Messaging.Base;

namespace IdentityServiceInterfaces.Messaging.AuthorizationService
{
    [DataContract, Serializable]
    public class IsAuthorizedRequest:RequestBase
    {
        [DataMember]
        public Right Right { get; set; }
    }
}
