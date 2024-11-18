using PROG7312_POE.Class.TreeClass;
using System;
using System.Collections.Generic;

namespace PROG7312_POE.Class.Models
{
    public class RedBlackTree
    {
        private static RedBlackTreeNode _root;
        private int _nextId; // This is the counter for generating custom IDs

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Primary Constructor
        /// </summary>
        public RedBlackTree()
        {
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Insert a new ReportedRequest into the Red-Black Tree
        /// </summary>
        public void Insert(ReportedRequest request)
        {
            IDSingleton IDSingleton = new IDSingleton();
            _nextId = 1;
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

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Insert a new ReportedRequest into the Red-Black Tree Node
        /// </summary>
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

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// ensures insertion follows Tree rules
        /// </summary>
        private void FixInsertion(RedBlackTreeNode node)
        {
            while (node != _root && node.Parent.IsRed)
            {
                var parent = node.Parent;
                var grandparent = parent.Parent;

                if (grandparent == null)
                    break;

                if (parent == grandparent.Left)
                {
                    var uncle = grandparent.Right;
                    if (uncle != null && uncle.IsRed) // Case 1: Recolor
                    {
                        parent.IsRed = false;
                        uncle.IsRed = false;
                        grandparent.IsRed = true;
                        node = grandparent; // Move up the tree
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
                        node = grandparent; // Move up the tree
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

        //-------------------------------------------------------------------------------------
        /// <summary>
        ///  Rotates the Node to the Left
        /// </summary>
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

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Rotates the Node to the Right
        /// </summary>
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

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Get's Node Uncle
        /// </summary>
        private RedBlackTreeNode GetUncle(RedBlackTreeNode node)
        {
            var grandparent = node.Parent?.Parent;
            if (grandparent == null)
                return null;

            return node.Parent == grandparent.Left ? grandparent.Right : grandparent.Left;
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Searches for a Node using the RequestName
        /// </summary>
        public ReportedRequest nameSearch(String repName)
        {
            return nameSearch(_root, repName);
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Searches for a Node using the RequestName within tree
        /// </summary>
        private ReportedRequest nameSearch(RedBlackTreeNode node, string repName)
        {
            if (node == null)
                return null;

            if (node.Request.RequestName == repName)
                return node.Request;

            if (repName.CompareTo(node.Request.RequestName) < 0)
                return nameSearch(node.Left, repName);
            else
                return nameSearch(node.Right, repName);
        }

        // Search for a service request by RequestId
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Searches for a Node using the RequestId
        /// </summary>
        public ReportedRequest Search(Guid requestId)
        {
            return Search(_root, requestId);
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Searches for a Node using the RequestName within tree
        /// </summary>
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


        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Get all requests as a list
        /// </summary>
        public List<ReportedRequest> GetRequestsForListView()
        {
            var requests = new List<ReportedRequest>();
            GetRequestsForListView(_root, requests);
            return requests;
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// adds all requests to a list
        /// </summary>
        private void GetRequestsForListView(RedBlackTreeNode node, List<ReportedRequest> requests)
        {
            if (node == null) return;

            GetRequestsForListView(node.Left, requests);
            requests.Add(node.Request);  // Add the request to the list
            GetRequestsForListView(node.Right, requests);
        }
    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//