using System;

namespace DotsAndBoxes.Data.User
{
    public class User
    {
        public User() { }

        public User(string userName) : this() { UserName = userName; }
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public override string ToString() { return $"{{ {Id} | {UserName} }}"; }
    }
}