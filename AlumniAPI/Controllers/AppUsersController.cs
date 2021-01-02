using System.Collections.Generic;
using System.Linq;
using AlumniAPI.Data;
using AlumniAPI.Models;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
          var appUsers = _context.applicationUsers.ToList();   

          return appUsers;
        }


        // End-point for a specific user
        // api/appUsers/3
        [HttpGet("{Id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
          return _context.applicationUsers.Find(id);   
         
        }

    }
}