using System;
using CoreModel.Interfaces;

namespace CoreModel.Models
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public string Email { get; set; }
    }
}
