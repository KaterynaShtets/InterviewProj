using CoreModel.Models;
using DataAccessLayer.Data;
using DataAccessLayer.EFCore;

namespace DataAccessLayer.Repositories
{
    public class UserRepository : Repository<User, ApplicationContext>
    {
        public UserRepository(ApplicationContext context) : base(context) { }
    }
}
