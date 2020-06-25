using CoreModel.Models;
using DataAccessLayer.Data;
using DataAccessLayer.EFCore;

namespace DataAccessLayer.Repositories
{
    public class RoleRepository: Repository<Role,ApplicationContext>
    {
        public RoleRepository(ApplicationContext context): base(context) { }
    }
}
