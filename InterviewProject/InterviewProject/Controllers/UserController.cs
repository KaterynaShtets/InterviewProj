using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewProject.Models;
using InterviewProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InterviewProject.Controllers
{
    public class UserController : InterviewBaseController<User, UserRepository>
    {
        public UserController(UserRepository repository) : base(repository) { }
    }
}
