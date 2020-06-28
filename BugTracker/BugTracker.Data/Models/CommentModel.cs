using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Data.Models
{
    class CommentModel
    {
        public string CommentId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

    }
}
