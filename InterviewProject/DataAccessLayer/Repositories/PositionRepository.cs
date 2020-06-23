using InterviewProject.Data;
using InterviewProject.EFCore;
using InterviewProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Repositories
{
    public class PositionRepository : Repository<Position, ApplicationContext>
    {
        public PositionRepository(ApplicationContext context) : base(context) { }
    }
}
