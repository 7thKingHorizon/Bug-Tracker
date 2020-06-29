using System;

namespace BugTracker.Data.Models
{
    class CommentModel
    {
        public int Id { get; set; } 
        public DateTime CreatedDate { get; set; } 
        public UserModel CreatedBy { get; set; }
        public string Text { get; set; } 
    }
}
