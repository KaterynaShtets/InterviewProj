using InterviewProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class Grade: IEntity
    {
        public int Id { get; set; }
        public string GradeTitle { get; set; }
        //public List<Interview> Interviews { get; set; }
    }
}
