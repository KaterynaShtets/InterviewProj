using CoreModel.Interfaces;

namespace CoreModel.Models
{
    public class Role : IEntity
    {
        public int Id { get; set; }
        public string RoleTitle { get; set; }
    }
}
