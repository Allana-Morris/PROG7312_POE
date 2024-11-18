using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.Class
{
    public class PriorityComparer : IComparer<ReportedRequest>
    {
         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Compares two ReportedRequests to determine which one' priority is higher
        /// </summary>
        public int Compare(ReportedRequest x, ReportedRequest y)
        {
            if (x == null || y == null) return 0;

            // Compare based on priority first
            var priorityComparison = x.AssignPriority(x.Category).CompareTo(y.AssignPriority(y.Category));

            // If priorities are equal, compare by request date (older requests first)
            if (priorityComparison == 0)
            {
                return x.RequestDate.CompareTo(y.RequestDate);
            }

            return priorityComparison;
        }
    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//