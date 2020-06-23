using InterviewProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class Room : IEntity
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Name { get; set; }
       // public List<Interview> Interviews { get; set; }
    }
}
