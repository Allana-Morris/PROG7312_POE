using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.TreeClass
{
    public class TreeNode
    {
        public IssueClass Issue { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(IssueClass issue)
        {
            Issue = issue;
            Left = null;
            Right = null;
        }
    }
}
