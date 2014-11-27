using IdentityServiceInterfaces.Messaging.AuthorizationService;

namespace IdentityServiceInterfaces
{
    public interface IAuthorizationService
    {
        IsAuthorizedResponse IsAuthorized(IsAuthorizedRequest request);
        GetAllRolesResponse GetAllRoles(GetAllRolesRequest request);
    }

}
