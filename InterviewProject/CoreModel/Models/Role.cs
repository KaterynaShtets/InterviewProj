using InterviewProject.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class Role : IEntity
    {
        public int Id { get; set; }
        public string RoleTitle { get; set; }
        //public List<UserRole> UserRoles { get; set; }
    }
}
