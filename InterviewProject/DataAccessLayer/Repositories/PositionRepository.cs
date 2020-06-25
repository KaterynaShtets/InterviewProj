using CoreModel.Models;
using DataAccessLayer.Data;
using DataAccessLayer.EFCore;

namespace DataAccessLayer.Repositories
{
    public class PositionRepository : Repository<Position, ApplicationContext>
    {
        public PositionRepository(ApplicationContext context) : base(context) { }
    }
}
