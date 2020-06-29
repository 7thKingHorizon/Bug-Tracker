using BugTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Data.Interfaces
{
    interface ICreatable
    {

        DateTime CreatedDate { get; set; }

        UserModel CreatedBy { get; set; }

      

    }





}



