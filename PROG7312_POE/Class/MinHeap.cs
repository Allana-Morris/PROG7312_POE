using PROG7312_POE.Class.Models;
using System.Collections.Generic;

namespace PROG7312_POE.Class
{
    public class MinHeap
    {
        private List<ReportedRequest> heap;

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Primary Constructor that initializes heap list
        /// </summary>
        public MinHeap()
        {
            heap = new List<ReportedRequest>();
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Loads the items in the tree into the Heap
        /// </summary>
        public void loadHeap(RedBlackTree tree)
        {
            List<ReportedRequest> requests = tree.GetRequestsForListView();

            foreach (ReportedRequest request in requests)
            {
                Insert(request);
            }
        }


        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Insert a new item into the heap
        /// </summary>
        public void Insert(ReportedRequest request)
        {
            heap.Add(request);
            HeapifyUp(heap.Count - 1);
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Remove the minimum item (root) from the heap
        /// </summary>
        public ReportedRequest RemoveMin()
        {
            if (heap.Count == 0)
                return null;

            ReportedRequest minItem = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);

            return minItem;
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Helper method to heapify up
        /// </summary>
        private void HeapifyUp(int index)
        {
            while (index > 0 && heap[index].CompareTo(heap[(index - 1) / 2]) < 0)
            {
                var temp = heap[index];
                heap[index] = heap[(index - 1) / 2];
                heap[(index - 1) / 2] = temp;

                index = (index - 1) / 2;
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Helper method to heapify down
        /// </summary>
        private void HeapifyDown(int index)
        {
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;
            int smallest = index;

            if (leftChild < heap.Count && heap[leftChild].CompareTo(heap[smallest]) < 0)
            {
                smallest = leftChild;
            }

            if (rightChild < heap.Count && heap[rightChild].CompareTo(heap[smallest]) < 0)
            {
                smallest = rightChild;
            }

            if (smallest != index)
            {
                var temp = heap[index];
                heap[index] = heap[smallest];
                heap[smallest] = temp;

                HeapifyDown(smallest);
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Get the heap content (the list of items in the heap)
        /// </summary>
        public List<ReportedRequest> GetHeapContent()
        {
            return heap;
        }
    }

}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//