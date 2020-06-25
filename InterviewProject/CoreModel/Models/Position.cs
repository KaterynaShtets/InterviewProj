using CoreModel.Interfaces;

namespace CoreModel.Models
{
    public class Position : IEntity
    {
        public int Id { get; set; }
        public string PositionTitle { get; set; }
    }
}
