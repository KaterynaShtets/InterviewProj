using InterviewProject.Data;
using InterviewProject.EFCore;
using InterviewProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Repositories
{
    public class InterviewUserRepository: Repository<InterviewUser,ApplicationContext>
    {
        public InterviewUserRepository(ApplicationContext context) : base(context) { }
    }
}
