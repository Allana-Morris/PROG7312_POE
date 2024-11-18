using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG7312_POE.Class.Models;

namespace PROG7312_POE.Class.TreeClass
{

    public class RedBlackTreeNode
    {
        public ReportedRequest Request { get; set; }
        public RedBlackTreeNode Left { get; set; }
        public RedBlackTreeNode Right { get; set; }
        public RedBlackTreeNode Parent { get; set; }
        public bool IsRed { get; set; }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Primary Constructor
        /// </summary>
        public RedBlackTreeNode(ReportedRequest request)
        {
            Request = request;
            Left = Right = Parent = null;
            IsRed = true; // New nodes are always red
        }
    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//