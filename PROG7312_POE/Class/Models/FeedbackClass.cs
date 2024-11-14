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

        public FeedbackClass() { }

        public FeedbackClass(string userSatisfied, string userAdvice)
        {
            UserSatisfied = userSatisfied;
            UserAdvice = userAdvice;
        }

    }
}
