using CoreModel.Interfaces;

namespace CoreModel.Models
{
    public class Technology : IEntity
    {
        public int Id { get; set; }
        public string TechnologyTitle { get; set; }
    }
}
