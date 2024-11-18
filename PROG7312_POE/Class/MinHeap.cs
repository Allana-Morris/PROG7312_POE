using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.Class
{
    public class MinHeap
    {
        private List<ReportedRequest> heap;

        public MinHeap()
        {
            heap = new List<ReportedRequest>();
        }

        // Insert a new item into the heap
        public void Insert(ReportedRequest request)
        {
            heap.Add(request);
            HeapifyUp(heap.Count - 1);
        }

        // Remove the minimum item (root) from the heap
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

        // Helper method to heapify up
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

        // Helper method to heapify down
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

        // Get the heap content (the list of items in the heap)
        public List<ReportedRequest> GetHeapContent()
        {
            return heap;
        }
    }

}
