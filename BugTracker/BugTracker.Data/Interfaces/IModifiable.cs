using BugTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Data.Interfaces
{
    interface IModifiable
    {
        

        DateTime ModifiedDate { get; set; }

        UserModel ModifiedBy { get; set; }

    }
}
