using System;
using System.Collections.Generic;
using LeaveApp.API.Models;

namespace LeaveApp.API.Dtos
{
    public class UserForDatailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }

        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string LookingFor { get; set; }
        public string Introduction { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Role { get; set; }
        public int Age { get; set; }
        public string PhotoUrl { get; set; }

        public ICollection<PhotosForDetailedDto> Photos { get; set; }

        public ICollection<LeaveForListDto> Leaves { get; set; }

        public ICollection<LeaveAvailableDto> LeaveAvailables { get; set; }
    }
}