using InterviewProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class Technology : IEntity
    {
        public int Id { get; set; }
        public string TechnologyTitle { get; set; }
       // public List<Interview> Interviews { get; set; }
    }
}
