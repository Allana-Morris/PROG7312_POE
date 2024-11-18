using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.Class.Models
{
    public class FeedbackClass
    {
        public string UserSatisfied { get; set; }
        public string UserAdvice { get; set; }
         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Primary Constructor
        /// </summary>
        public FeedbackClass() { }

         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Constructor to initialize data
        /// </summary>
        public FeedbackClass(string userSatisfied, string userAdvice)
        {
            UserSatisfied = userSatisfied;
            UserAdvice = userAdvice;
        }
    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//