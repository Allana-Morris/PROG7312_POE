using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG7312_POE.Class.Models;

namespace PROG7312_POE.Class.TreeClass
{
    public enum Color
    {
        Red,
        Black
    }

    public class TreeNode
    {
        public ReportedRequest Request { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode Parent { get; set; }
        public Color NodeColor { get; set; }

        public TreeNode(ReportedRequest request)
        {
            Request = request;
            Left = null;
            Right = null;
            Parent = null;
            NodeColor = Color.Red; // New nodes are always inserted as red
        }
    }
}
