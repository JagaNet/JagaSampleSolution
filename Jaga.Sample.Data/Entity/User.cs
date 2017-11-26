using System;

namespace Jaga.Sample.Data.Entity
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool ModifiedState { get; set; }
    }
}
