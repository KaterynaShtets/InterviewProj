using InterviewProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class Interview : IEntity
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int PositionId { get; set; }
        //public Position Position { get; set; }
        public int GradeId { get; set; }
        //public Grade Grade { get; set; }
        public int TechnologyId { get; set; }
       // public Technology Technology { get; set; }
        public int RoomId { get; set; }
        //public Room Room { get; set; }
        //public List<InterviewUser> InterviewUser { get; set; }
    }
}
