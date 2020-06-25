using CoreModel.Interfaces;

namespace CoreModel.Models
{
    public class Grade: IEntity
    {
        public int Id { get; set; }
        public string GradeTitle { get; set; }
    }
}
