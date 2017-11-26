using System;

namespace Jaga.Sample.Data.Entity
{
    public class User:BaseEntity
    {
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
