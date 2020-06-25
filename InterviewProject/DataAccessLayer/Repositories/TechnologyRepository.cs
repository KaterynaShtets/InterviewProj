using CoreModel.Models;
using DataAccessLayer.Data;
using DataAccessLayer.EFCore;

namespace DataAccessLayer.Repositories
{
    public class TechnologyRepository: Repository<Technology, ApplicationContext>
    {
        public TechnologyRepository(ApplicationContext context) : base(context) { }
    }
}
