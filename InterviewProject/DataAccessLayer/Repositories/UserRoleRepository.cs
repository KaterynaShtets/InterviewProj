using CoreModel.Models;
using DataAccessLayer.Data;
using DataAccessLayer.EFCore;

namespace DataAccessLayer.Repositories
{
    public class UserRoleRepository : Repository<UserRole, ApplicationContext>
    {
        public UserRoleRepository(ApplicationContext context) : base(context) { }
    }
}
