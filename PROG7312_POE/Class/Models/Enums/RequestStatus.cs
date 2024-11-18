using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.Class.Models.Enums
{
     //-------------------------------------------------------------------------------------
        /// <summary>
        /// Contains the status the Request can be assigned
        /// </summary>
    public enum RequestStatus
    {
        [Description("Request Open")]
        Open,

        [Description("In Progress")]
        InProgress,

        [Description("Closed")]
        Closed
    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//