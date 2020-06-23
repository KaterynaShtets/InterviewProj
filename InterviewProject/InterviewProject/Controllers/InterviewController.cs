using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewProject.Models;
using InterviewProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InterviewProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewController : InterviewBaseController<Interview, InterviewRepository>
    {
        public InterviewController(InterviewRepository repository) : base(repository) { }
        
    }
}
