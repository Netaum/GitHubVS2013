using IdentityService.Domain.Interfaces;

namespace IdentityService.Domain.Behaviours
{
    public class HashBuildBehavior : IHashBuildBehavior
    {
        public string BuildHash(string value)
        {
            return value.ToLower();
        }
    }
}
