using CoreModel.Interfaces;

namespace CoreModel.Models
{
    public class UserRole : IEntity
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
    }
}
