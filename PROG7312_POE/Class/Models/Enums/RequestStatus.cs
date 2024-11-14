using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.Class.Models.Enums
{
    public enum RequestStatus
    {
        [Description("Pending")]
        Pending,

        [Description("In Progress")]
        InProgress,

        [Description("Resolved")]
        Resolved
    }
}
