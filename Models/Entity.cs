using System;

namespace UnitOfWorkProject.Models
{
    public class Entity
    {
        public int Id { get; protected set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}