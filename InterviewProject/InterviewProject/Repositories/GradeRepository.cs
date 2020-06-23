using InterviewProject.Data;
using InterviewProject.EFCore;
using InterviewProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Repositories
{
    public class GradeRepository: Repository<Grade, ApplicationContext>
    {
        public GradeRepository(ApplicationContext context): base(context) { }
    }
}
