using System;

namespace LearningDDD.Domain.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string UserAlias { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
