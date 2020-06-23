using InterviewProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class UserRole : IEntity
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
     //   public Role Role { get; set; }
        public int UserId { get; set; }
     //   public User User { get; set; }

    }
}
