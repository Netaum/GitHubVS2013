using IdentityService.Domain.Behaviours;
using IdentityService.Domain.Entities;
using IdentityService.Domain.Interfaces;

namespace IdentityService.Domain.Services
{
    public class Credential
    {
        private readonly IHashBuildBehavior _hashBuildBehavior;

        public User User { get; protected set; }

        public Credential(IHashBuildBehavior hashBuildBehavior, User user)
        {
            _hashBuildBehavior = new HashBuildBehavior();
            User = user;

        }
    }

    public class CredentialBuilder
    {
        private IHashBuildBehavior _hashBuildBehavior;
        private string _eMail;
        private string _passWord;

        public CredentialBuilder(string eMail, string passWord)
        {
            _eMail = eMail;
            _passWord = passWord;
            _hashBuildBehavior = new HashBuildBehavior();
        }

        public CredentialBuilder WithHashBuilderBehavior(IHashBuildBehavior hashBuildBehavior)
        {
            _hashBuildBehavior = hashBuildBehavior;
            return this;
        }

        public Credential Build()
        {
            return new Credential(_hashBuildBehavior, new User("", _eMail, _passWord));
        }
    }
}
