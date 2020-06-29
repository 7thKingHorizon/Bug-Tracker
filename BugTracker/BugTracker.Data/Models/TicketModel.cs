using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Data.Models
{
    class TicketModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Detail { get; set; }

        public List<UserModel> Assignments { get; set; }

        public List<UserModel> Followers { get; set; }
        public DateTime CreatedDate { get; set; }
        public UserModel CreatedBy { get; set; }

    }
}
