using CoreModel.Interfaces;

namespace CoreModel.Models
{
    public class Room : IEntity
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }
    }
}
