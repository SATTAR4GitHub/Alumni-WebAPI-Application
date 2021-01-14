using System;
using System.Collections.Generic;

namespace AlumniAPI.DTOs
{
    public class MemberDto
    {
         public int Id { get; set; }
        public string Username { get; set; }
        public string PhotoUrl {get; set;}
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Batch {get; set;}
        public string Email { get; set; }
        public string CurrentPosition { get; set; }
        public string EmploymentHistory { get; set; }
        public string Achievements { get; set; }
        public string Memory { get; set; }
        public string OtherDetails { get; set; }
        public ICollection<PhotoDto> Photos { get; set; }
    }
}