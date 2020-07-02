using BugTracker.Data.Interfaces;
using System;

namespace BugTracker.Data.Models
{
  public class CommentModel : ICreatable
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public UserModel CreatedBy { get; set; }
        public string Text { get; set; }
    }
}
