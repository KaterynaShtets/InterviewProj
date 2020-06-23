using InterviewProject.Data;
using InterviewProject.EFCore;
using InterviewProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Repositories
{
    public class TechnologyRepository: Repository<Technology, ApplicationContext>
    {
        public TechnologyRepository(ApplicationContext context) : base(context) { }
    }
}
