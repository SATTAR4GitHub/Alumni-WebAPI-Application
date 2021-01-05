using AlumniAPI.Models;

namespace AlumniAPI.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}