using System;
using System.Collections.Generic;

namespace PROG7312_POE.Class.TreeClass
{
    public class RedBlackTree
    {
        private TreeNode root;

        public RedBlackTree()
        {
            root = null;
        }

        public void Insert(ReportedRequest request)
        {
            TreeNode newNode = new TreeNode(request);
            root = Insert(root, newNode);
            FixInsert(newNode);
        }

        private TreeNode Insert(TreeNode node, TreeNode newNode)
        {
            if (node == null)
                return newNode;

            // Compare based on ReportedRequest's RequestId (using CompareTo method)
            if (newNode.Request.CompareTo(node.Request) < 0)
            {
                node.Left = Insert(node.Left, newNode);
                node.Left.Parent = node;
            }
            else
            {
                node.Right = Insert(node.Right, newNode);
                node.Right.Parent = node;
            }

            return node;
        }

        private void FixInsert(TreeNode node)
        {
            while (node != root && node.Parent.NodeColor == Color.Red)
            {
                if (node.Parent == node.Parent.Parent.Left)
                {
                    TreeNode uncle = node.Parent.Parent.Right;
                    if (uncle != null && uncle.NodeColor == Color.Red)
                    {
                        node.Parent.NodeColor = Color.Black;
                        uncle.NodeColor = Color.Black;
                        node.Parent.Parent.NodeColor = Color.Red;
                        node = node.Parent.Parent;
                    }
                    else
                    {
                        if (node == node.Parent.Right)
                        {
                            node = node.Parent;
                            LeftRotate(node);
                        }

                        node.Parent.NodeColor = Color.Black;
                        node.Parent.Parent.NodeColor = Color.Red;
                        RightRotate(node.Parent.Parent);
                    }
                }
                else
                {
                    TreeNode uncle = node.Parent.Parent.Left;
                    if (uncle != null && uncle.NodeColor == Color.Red)
                    {
                        node.Parent.NodeColor = Color.Black;
                        uncle.NodeColor = Color.Black;
                        node.Parent.Parent.NodeColor = Color.Red;
                        node = node.Parent.Parent;
                    }
                    else
                    {
                        if (node == node.Parent.Left)
                        {
                            node = node.Parent;
                            RightRotate(node);
                        }

                        node.Parent.NodeColor = Color.Black;
                        node.Parent.Parent.NodeColor = Color.Red;
                        LeftRotate(node.Parent.Parent);
                    }
                }
            }

            root.NodeColor = Color.Black; // Root is always black
        }

        private void LeftRotate(TreeNode x)
        {
            TreeNode y = x.Right;
            x.Right = y.Left;
            if (y.Left != null)
                y.Left.Parent = x;

            y.Parent = x.Parent;
            if (x.Parent == null)
                root = y;
            else if (x == x.Parent.Left)
                x.Parent.Left = y;
            else
                x.Parent.Right = y;

            y.Left = x;
            x.Parent = y;
        }

        private void RightRotate(TreeNode x)
        {
            TreeNode y = x.Left;
            x.Left = y.Right;
            if (y.Right != null)
                y.Right.Parent = x;

            y.Parent = x.Parent;
            if (x.Parent == null)
                root = y;
            else if (x == x.Parent.Right)
                x.Parent.Right = y;
            else
                x.Parent.Left = y;

            y.Right = x;
            x.Parent = y;
        }

        public List<ReportedRequest> InOrderTraversal()
        {
            var result = new List<ReportedRequest>();
            InOrderTraversal(root, result);
            return result;
        }

        private void InOrderTraversal(TreeNode node, List<ReportedRequest> result)
        {
            if (node == null) return;

            InOrderTraversal(node.Left, result);
            result.Add(node.Request);
            InOrderTraversal(node.Right, result);
        }

        public bool Search(ReportedRequest request)
        {
            return Search(root, request) != null;
        }

        private TreeNode Search(TreeNode node, ReportedRequest request)
        {
            if (node == null) return null;

            if (request.CompareTo(node.Request) == 0)
                return node;
            else if (request.CompareTo(node.Request) < 0)
                return Search(node.Left, request);
            else
                return Search(node.Right, request);
        }
    }
}
