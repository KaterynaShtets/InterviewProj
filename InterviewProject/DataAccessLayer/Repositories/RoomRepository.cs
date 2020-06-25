using CoreModel.Models;
using DataAccessLayer.Data;
using DataAccessLayer.EFCore;

namespace DataAccessLayer.Repositories
{
    public class RoomRepository: Repository<Room, ApplicationContext>
    {
        public RoomRepository(ApplicationContext context): base(context) { }
    }
}
