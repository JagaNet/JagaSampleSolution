using System;

namespace Jaga.Sample.Data.Entity
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public bool ModifiedState { get; set; }
    }

}
