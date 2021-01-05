using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlumniAPI.Data;
using AlumniAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlumniAPI.Controllers
{
    public class AppUsersController : BaseAPIController
    {
        private readonly ApplicationDbContext _context;
        public AppUsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // End-point for all users
        // api/appUsers
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
          var appUsers = await _context.applicationUsers.ToListAsync();   

          return appUsers;
        } 


        // End-point for a specific user
        // api/appUsers/2
        [HttpGet("{Id}")]
        [Authorize]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
          return await _context.applicationUsers.FindAsync(id);   
         
        }

    }
}