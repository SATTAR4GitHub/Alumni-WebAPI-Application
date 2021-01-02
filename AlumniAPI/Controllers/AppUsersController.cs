using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlumniAPI.Data;
using AlumniAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlumniAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppUsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public AppUsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // End-point for all users
        // api/appUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
          var appUsers = await _context.applicationUsers.ToListAsync();   

          return appUsers;
        } 


        // End-point for a specific user
        // api/appUsers/2
        [HttpGet("{Id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
          return await _context.applicationUsers.FindAsync(id);   
         
        }

    }
}