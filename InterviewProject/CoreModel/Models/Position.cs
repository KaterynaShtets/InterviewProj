using InterviewProject.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
   
    public class Position : IEntity
    {
        public int Id { get; set; }
        public string PositionTitle { get; set; }
        //public List<Interview> Interviews { get; set; }
    }
}
