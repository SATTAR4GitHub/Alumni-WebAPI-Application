using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AlumniAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlumniAPI.Data
{
    public class SeedData
    {
        public static async Task SeedUsers(ApplicationDbContext context)
        {
            if (await context.applicationUsers.AnyAsync()) return;

            var userData = await System.IO.File.ReadAllTextAsync("Data/UserData.json");
            var users = JsonSerializer.Deserialize<List<AppUser>>(userData);
            
            if (users == null) return;

            foreach (var user in users)
            {
                using var hmac = new HMACSHA512();
                user.UserName = user.UserName.ToLower();
                user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Password"));
                user.PasswordSalt = hmac.Key;

                context.applicationUsers.Add(user);
            }

            await context.SaveChangesAsync();
        }
    }
}