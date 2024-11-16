using PROG7312_POE.Class.TreeClass;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;  // Assuming Windows Forms for ListView

namespace PROG7312_POE.Class.Models
{
    public class RedBlackTree
    {
        private static RedBlackTreeNode _root;
        private IDSingleton IDSingleton = new IDSingleton();
        private int _nextId; // This is the counter for generating custom IDs

        public RedBlackTree()
        {
            _nextId = 1;
        }

        // Insert a new ReportedRequest into the Red-Black Tree
        public void Insert(ReportedRequest request)
        {
            int customRequestId = _nextId + IDSingleton.idcount;

            var nRequest = new ReportedRequest(customRequestId++, request);

            IDSingleton.IDPlus();

            var newNode = new RedBlackTreeNode(nRequest);
            if (_root == null)
            {
                _root = newNode;
                _root.IsRed = false; // Root is always black
            }
            else
            {
                InsertNode(_root, newNode);
                FixInsertion(newNode);
            }
        }

        private void InsertNode(RedBlackTreeNode current, RedBlackTreeNode newNode)
        {
            if (newNode.Request.CompareTo(current.Request) < 0)
            {
                if (current.Left == null)
                {
                    current.Left = newNode;
                    newNode.Parent = current;
                }
                else
                {
                    InsertNode(current.Left, newNode);
                }
            }
            else
            {
                if (current.Right == null)
                {
                    current.Right = newNode;
                    newNode.Parent = current;
                }
                else
                {
                    InsertNode(current.Right, newNode);
                }
            }
        }

        private void FixInsertion(RedBlackTreeNode node)
        {
            while (node != _root && node.Parent.IsRed)
            {
                var parent = node.Parent;
                var grandparent = parent.Parent;

                if (parent == grandparent.Left)
                {
                    var uncle = grandparent.Right;
                    if (uncle != null && uncle.IsRed) // Case 1: Recolor
                    {
                        parent.IsRed = false;
                        uncle.IsRed = false;
                        grandparent.IsRed = true;
                        node = grandparent;
                    }
                    else
                    {
                        if (node == parent.Right) // Case 2: Left Rotation
                        {
                            node = parent;
                            RotateLeft(node);
                        }
                        parent.IsRed = false; // Case 3: Right Rotation
                        grandparent.IsRed = true;
                        RotateRight(grandparent);
                    }
                }
                else
                {
                    var uncle = grandparent.Left;
                    if (uncle != null && uncle.IsRed) // Case 1: Recolor
                    {
                        parent.IsRed = false;
                        uncle.IsRed = false;
                        grandparent.IsRed = true;
                        node = grandparent;
                    }
                    else
                    {
                        if (node == parent.Left) // Case 2: Right Rotation
                        {
                            node = parent;
                            RotateRight(node);
                        }
                        parent.IsRed = false; // Case 3: Left Rotation
                        grandparent.IsRed = true;
                        RotateLeft(grandparent);
                    }
                }
            }
            _root.IsRed = false; // Ensure root is black
        }

        private void RotateLeft(RedBlackTreeNode node)
        {
            var pivot = node.Right;
            node.Right = pivot.Left;
            if (pivot.Left != null)
            {
                pivot.Left.Parent = node;
            }
            pivot.Parent = node.Parent;
            if (node.Parent == null)
            {
                _root = pivot;
            }
            else if (node == node.Parent.Left)
            {
                node.Parent.Left = pivot;
            }
            else
            {
                node.Parent.Right = pivot;
            }
            pivot.Left = node;
            node.Parent = pivot;
        }

        private void RotateRight(RedBlackTreeNode node)
        {
            var pivot = node.Left;
            node.Left = pivot.Right;
            if (pivot.Right != null)
            {
                pivot.Right.Parent = node;
            }
            pivot.Parent = node.Parent;
            if (node.Parent == null)
            {
                _root = pivot;
            }
            else if (node == node.Parent.Right)
            {
                node.Parent.Right = pivot;
            }
            else
            {
                node.Parent.Left = pivot;
            }
            pivot.Right = node;
            node.Parent = pivot;
        }

        public ReportedRequest nameSearch(String repName)
        {
            return nameSearch(_root, repName);
        }

        private ReportedRequest nameSearch(RedBlackTreeNode node, string repName)
        {
            if (node == null)
                return null;

            if (node.Request.RequestName == repName)
                return node.Request;

            if (repName.CompareTo(node.Request.RequestId) < 0)
                return nameSearch(node.Left, repName);
            else
                return nameSearch(node.Right, repName);
        }

        // Search for a service request by RequestId
        public ReportedRequest Search(Guid requestId)
        {
            return Search(_root, requestId);
        }

        private ReportedRequest Search(RedBlackTreeNode node, Guid requestId)
        {
            if (node == null)
                return null;

            if (node.Request.RequestId == requestId)
                return node.Request;

            if (requestId.CompareTo(node.Request.RequestId) < 0)
                return Search(node.Left, requestId);
            else
                return Search(node.Right, requestId);
        }

        // Get all requests as a list
        public List<ReportedRequest> GetRequestsForListView()
        {
            var requests = new List<ReportedRequest>();
            GetRequestsForListView(_root, requests);
            return requests;
        }

        private void GetRequestsForListView(RedBlackTreeNode node, List<ReportedRequest> requests)
        {
            if (node == null) return;

            GetRequestsForListView(node.Left, requests);
            requests.Add(node.Request);  // Add the request to the list
            GetRequestsForListView(node.Right, requests);
        }
    }
}
