using System;
using System.Collections.Generic;
using AlumniAPI.Extensions;

namespace AlumniAPI.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime  Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string Gender { get; set; }
        public string  Introduction { get; set; }
        public string  LookingFor { get; set; }
        public string  Interests { get; set; }
        public string  City { get; set; }
        public string  Country { get; set; }
        public int Batch {get; set;}
        public string Email { get; set; }
        public string CurrentPosition { get; set; }
        public string EmploymentHistory { get; set; }
        public string Achievements { get; set; }
        public string Memory { get; set; }
        public string OtherDetails { get; set; }
        // one-many relationship with Photo class. One user has many photos.
        public ICollection<Photo> Photos { get; set; }

        // public int GetAge()
        // {
        //     return DateOfBirth.CalculateAge();
        // }

    }
}