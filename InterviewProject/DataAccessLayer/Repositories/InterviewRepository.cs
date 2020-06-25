using CoreModel.Models;
using DataAccessLayer.Data;
using DataAccessLayer.EFCore;


namespace DataAccessLayer.Repositories
{
    public class InterviewRepository : Repository<Interview, ApplicationContext>
    {
        public InterviewRepository(ApplicationContext context) : base(context) { }
    }
}
