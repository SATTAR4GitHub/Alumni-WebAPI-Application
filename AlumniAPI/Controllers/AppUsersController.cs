using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlumniAPI.Data;
using AlumniAPI.DTOs;
using AlumniAPI.Interfaces;
using AlumniAPI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlumniAPI.Controllers
{
    [Authorize]
    public class AppUsersController : BaseAPIController
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public AppUsersController(IUserRepository userRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;

        }

        // End-point for all users
        // api/appUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
            var users = await _userRepository.GetMembersAsync();
            
            return Ok(users);
        }


        // End-point for a specific user
        // api/appUsers/2
        [HttpGet("{username}")]
        public async Task<ActionResult<MemberDto>> GetUser(string username)
        {
            return await _userRepository.GetMemberAsync(username);
        }

    }
}