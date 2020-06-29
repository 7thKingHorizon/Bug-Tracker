using BugTracker.Data.Models;
using System;

namespace BugTracker.Data.Interfaces
{
    interface IModifiable
    {
        DateTime ModifiedDate { get; set; }
        UserModel ModifiedBy { get; set; }
    }
}
