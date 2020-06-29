using BugTracker.Data.Interfaces;
using System;

namespace BugTracker.Data.Models
{
    class UserModel : ICreatable, IModifiable
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public UserModel CreatedBy { get { return this; } set { } }
        public DateTime ModifiedDate { get; set; }
        public UserModel ModifiedBy { get; set; }
    }
}
