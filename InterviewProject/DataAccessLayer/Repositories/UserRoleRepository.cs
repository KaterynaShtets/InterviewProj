using InterviewProject.Data;
using InterviewProject.EFCore;
using InterviewProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Repositories
{
    public class UserRoleRepository : Repository<UserRole, ApplicationContext>
    {
        public UserRoleRepository(ApplicationContext context) : base(context) { }
    }
}
