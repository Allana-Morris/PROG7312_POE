using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.TreeClass
{
    public class BinarySearchTree
    {
        private TreeNode root;

        // Insert a new issue into the tree
        public void Insert(IssueClass issue)
        {
            root = InsertRecursive(root, issue);
        }

        private TreeNode InsertRecursive(TreeNode node, IssueClass issue)
        {
            if (node == null)
                return new TreeNode(issue);

            if (issue.userSubmissionDate < node.Issue.userSubmissionDate)
                node.Left = InsertRecursive(node.Left, issue);
            else
                node.Right = InsertRecursive(node.Right, issue);

            return node;
        }

        // Retrieve issues in order of submission
        public List<IssueClass> GetIssuesInOrder()
        {
            List<IssueClass> issues = new List<IssueClass>();
            InOrderTraversal(root, issues);
            return issues;
        }

        private void InOrderTraversal(TreeNode node, List<IssueClass> issues)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left, issues);
                issues.Add(node.Issue);
                InOrderTraversal(node.Right, issues);
            }
        }
    }

}
