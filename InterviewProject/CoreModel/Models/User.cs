using InterviewProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public string Email { get; set; }
      //  public List<UserRole> UserRoles { get; set; }
      //  public List<InterviewUser> InterviewUser { get; set; }
    }
}
