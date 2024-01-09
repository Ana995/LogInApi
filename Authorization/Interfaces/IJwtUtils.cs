using LogInApi.Entities;

namespace LogInApi.Authorization.Interfaces
{
    public interface IJwtUtils
    {
        public string GenerateToken(User user);

        public int? ValidateToken(string token);
    }
}
