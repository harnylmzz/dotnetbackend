using dotnetbackend.Domain.Common;
using dotnetbackend.Domain.ValueObjects;

namespace dotnetbackend.Domain.Entities
{
    public class User : EntityBase
    {
        public Email Email { get; set; }

        public FullName FullName { get; set; }

        public PhoneNumber PhoneNumber { get; set; }
    }
}
