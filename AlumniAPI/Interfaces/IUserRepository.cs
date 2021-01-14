using System.Collections.Generic;
using System.Threading.Tasks;
using AlumniAPI.DTOs;
using AlumniAPI.Models;

namespace AlumniAPI.Interfaces
{
    public interface IUserRepository
    {
         void Update(AppUser user);
         Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
        Task<IEnumerable<MemberDto>> GetMembersAsync();
        Task<MemberDto> GetMemberAsync(string username);
        //Task<string> GetUserGender(string username);
    }
}