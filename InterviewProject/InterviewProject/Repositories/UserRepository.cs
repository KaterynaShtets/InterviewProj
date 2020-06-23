using InterviewProject.Data;
using InterviewProject.EFCore;
using InterviewProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Repositories
{
    public class UserRepository : Repository<User, ApplicationContext>
    {
        public UserRepository(ApplicationContext context) : base(context) { }
    }
}
