namespace IdentityService.Domain.Interfaces
{
    public interface IHashBuildBehavior
    {
        string BuildHash(string value);
    }
}
