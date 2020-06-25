using System;
using CoreModel.Interfaces;

namespace CoreModel.Models
{
    public class Interview : IEntity
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int PositionId { get; set; }
        public int GradeId { get; set; }
        public int TechnologyId { get; set; }
        public int RoomId { get; set; }
    }
}
