using BugTracker.Data.Models;
using System;

namespace BugTracker.Data.Interfaces
{
    interface ICreatable
    {
        DateTime CreatedDate { get; set; }
        UserModel CreatedBy { get; set; }
    }
}