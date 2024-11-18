using System.ComponentModel;

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