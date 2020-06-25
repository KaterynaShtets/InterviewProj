using CoreModel.Interfaces;

namespace CoreModel.Models
{
    public class InterviewUser : IEntity
    {
        public int Id { get; set; }
        public int InterviewId { get; set; }
        public int UserId { get; set; }
    }
}
