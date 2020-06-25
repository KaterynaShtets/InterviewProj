using CoreModel.Models;
using DataAccessLayer.Data;
using DataAccessLayer.EFCore;

namespace DataAccessLayer.Repositories
{
    public class GradeRepository: Repository<Grade, ApplicationContext>
    {
        public GradeRepository(ApplicationContext context): base(context) { }
    }
}
