using IdentityService.Domain.Behaviours;
using IdentityService.Domain.Interfaces;

namespace IdentityService.Domain.Entities
{
    public class User
    {
        private readonly IHashBuildBehavior _hashBehavior;

        public int IdUser { get; protected set; }

        public string Name { get; protected set; }

        public string EMail { get; protected set; }

        private string _password;

        protected User()
        {
            _hashBehavior = new HashBuildBehavior();
        }

        public User(string name, string email, string password)
        {
            Name = name;
            EMail = email;
            _password = password;
        }

        public User( string email, string password)
        {
            EMail = email;
            _password = password;
        }

        public bool IsPasswordValid(string password)
        {
            return BuildHash(password) == PasswordHash;
        }

        private string BuildHash(string password)
        {
            return _hashBehavior.BuildHash(password);
        }
    }
}
