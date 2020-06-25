using CoreModel.Models;
using DataAccessLayer.Data;
using DataAccessLayer.EFCore;

namespace DataAccessLayer.Repositories
{
    public class InterviewUserRepository: Repository<InterviewUser,ApplicationContext>
    {
        public InterviewUserRepository(ApplicationContext context) : base(context) { }
    }
}
