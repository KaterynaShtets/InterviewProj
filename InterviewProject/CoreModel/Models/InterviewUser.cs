using InterviewProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class InterviewUser : IEntity
    {
        public int Id { get; set; }
        public int InterviewId { get; set; }
       // public Interview Interview { get; set; }
        public int UserId { get; set; }
       // public User User { get; set; }
    }
}
